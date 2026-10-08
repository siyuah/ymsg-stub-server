using Google.Protobuf;
using Msg;

namespace YmsgStub.Server.Http;

/// <summary>
/// HTTP 登录接口：GetAllRegion / GetRegionLoginServer 等走 HTTP 而不是 TCP。
/// 请求与应答的 body 都按 Msg.HttpTransMsg { MsgID, MsgBody } 封装（MsgBody 为内层 protobuf），
/// 这是依据协议中的 HttpTransMsg 类型推断的，待抓包确认。
/// 客户端请求的 URL 路径未知，因此接受任意路径，只按 MsgID 分发；无法处理的请求会连同
/// body 的十六进制预览一起记入日志，便于对照客户端实际发出的格式。
/// </summary>
public sealed class HttpGateway
{
    private const int PreviewBytes = 64;

    private readonly Dictionary<uint, IHttpMessageHandler> _handlers = new();
    private readonly ILogger<HttpGateway> _logger;

    public HttpGateway(IEnumerable<IHttpMessageHandler> handlers, ILogger<HttpGateway> logger)
    {
        _logger = logger;
        foreach (var handler in handlers)
        {
            if (_handlers.TryAdd(handler.MessageId, handler))
                _logger.LogDebug("Registered HTTP handler {Name} for msgId {Id} ({MsgName})",
                    handler.GetType().Name, handler.MessageId,
                    MsgIdCatalog.Describe(handler.MessageId) ?? "不在 DLL 枚举中");
            else
                _logger.LogWarning("Duplicate HTTP handler for msgId {Id}: {Name}",
                    handler.MessageId, handler.GetType().Name);
        }
        _logger.LogInformation("HttpGateway: {Count} handlers registered", _handlers.Count);
    }

    public async Task HandleAsync(HttpContext ctx)
    {
        var request = ctx.Request;
        string target = $"{request.Method} {request.Path}{request.QueryString}";

        using var buffer = new MemoryStream();
        await request.Body.CopyToAsync(buffer, ctx.RequestAborted);
        byte[] body = buffer.ToArray();

        HttpTransMsg trans;
        try { trans = HttpTransMsg.Parser.ParseFrom(body); }
        catch (InvalidProtocolBufferException)
        {
            _logger.LogWarning("HTTP {Target}: body 不是 HttpTransMsg（{Len} bytes, Content-Type {Type}）: {Hex}",
                target, body.Length, request.ContentType, Preview(body));
            ctx.Response.StatusCode = StatusCodes.Status400BadRequest;
            return;
        }

        if (!_handlers.TryGetValue(trans.MsgID, out var handler))
        {
            _logger.LogWarning("HTTP {Target}: no handler for msgId {Id} ({MsgName}, {Len} bytes): {Hex}",
                target, trans.MsgID, MsgIdCatalog.Describe(trans.MsgID) ?? "未知",
                body.Length, Preview(body));
            ctx.Response.StatusCode = StatusCodes.Status404NotFound;
            return;
        }

        byte[] ackBody;
        try { ackBody = await handler.HandleAsync(trans.MsgBody.ToByteArray()); }
        catch (Exception ex)
        {
            _logger.LogError(ex, "HTTP handler error for msgId {Id}", trans.MsgID);
            ctx.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return;
        }

        var reply = new HttpTransMsg
        {
            MsgID   = trans.MsgID,
            MsgBody = ByteString.CopyFrom(ackBody),
        };
        _logger.LogDebug("HTTP {Target}: msgId {Id} → {Len} bytes", target, trans.MsgID, ackBody.Length);
        ctx.Response.ContentType = "application/octet-stream";
        await ctx.Response.Body.WriteAsync(reply.ToByteArray(), ctx.RequestAborted);
    }

    private static string Preview(byte[] body) =>
        body.Length == 0 ? "(空)"
        : Convert.ToHexString(body, 0, Math.Min(body.Length, PreviewBytes))
          + (body.Length > PreviewBytes ? "…" : "");
}
