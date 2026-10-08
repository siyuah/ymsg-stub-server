using Google.Protobuf;
using Msg;

namespace YmsgStub.Server.Http;

/// <summary>
/// HTTP 登录接口：GetAllRegion / GetRegionLoginServer 等走 HTTP 而不是 TCP。
/// 客户端的实际格式尚未确认，这里同时接受两种最可能的格式，应答格式与请求一致：
///   1. body 为 Msg.HttpTransMsg { MsgID, MsgBody }（MsgBody 为内层 protobuf）→ 回同样封装的应答；
///   2. body 为原始请求 protobuf，消息由 URL 指明（路径段或查询参数中的消息 ID / 请求类型名，
///      如 /9000、?msgid=9000、/GetAllRegion）→ 回原始应答 protobuf。
/// 每个请求按哪种格式处理都会记入日志；无法识别的请求连同 body 的十六进制预览一起记录。
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

        // protobuf 解析很宽松，未封装的请求也可能"解析成功"并得到无意义的 MsgID，
        // 所以只有 MsgID 对应已注册的 handler 时才认定为 HttpTransMsg 封装
        var trans = TryParseTransMsg(body);
        bool wrapped = trans is not null && _handlers.ContainsKey(trans.MsgID);
        var handler = wrapped ? _handlers[trans!.MsgID] : FindHandlerByUrl(request);
        if (handler is null)
        {
            _logger.LogWarning("HTTP {Target}: 无法识别的请求（{Len} bytes, Content-Type {Type}, " +
                "按 HttpTransMsg 解析得 MsgID {Id}）: {Hex}",
                target, body.Length, request.ContentType ?? "-",
                trans is null ? "-" : $"{trans.MsgID} ({MsgIdCatalog.Describe(trans.MsgID) ?? "未知"})",
                Preview(body));
            ctx.Response.StatusCode = StatusCodes.Status404NotFound;
            return;
        }

        byte[] ackBody;
        try { ackBody = await handler.HandleAsync(wrapped ? trans!.MsgBody.ToByteArray() : body); }
        catch (Exception ex)
        {
            _logger.LogError(ex, "HTTP handler error for {Target} ({Name})", target, handler.MessageName);
            ctx.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return;
        }

        byte[] reply = wrapped
            ? new HttpTransMsg { MsgID = handler.MessageId, MsgBody = ByteString.CopyFrom(ackBody) }.ToByteArray()
            : ackBody;
        _logger.LogInformation("HTTP {Target}: {Name}（{Format}）→ {Len} bytes",
            target, handler.MessageName, wrapped ? "HttpTransMsg 封装" : "原始 protobuf", reply.Length);
        ctx.Response.ContentType = "application/octet-stream";
        // 显式给出长度，不用 chunked 编码，兼容只认 Content-Length 的简易 HTTP 客户端
        ctx.Response.ContentLength = reply.Length;
        await ctx.Response.Body.WriteAsync(reply, ctx.RequestAborted);
    }

    private static HttpTransMsg? TryParseTransMsg(byte[] body)
    {
        try { return HttpTransMsg.Parser.ParseFrom(body); }
        catch (InvalidProtocolBufferException) { return null; }
    }

    // 未封装的请求：在路径段和查询参数（键和值）中找消息 ID 或请求类型名
    private IHttpMessageHandler? FindHandlerByUrl(HttpRequest request)
    {
        var tokens = (request.Path.Value ?? "").Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Concat(request.Query.Keys)
            .Concat(request.Query.SelectMany(q => q.Value.Select(v => v ?? "")));
        foreach (var token in tokens)
        {
            if (uint.TryParse(token, out uint id) && _handlers.TryGetValue(id, out var byId))
                return byId;
            var byName = _handlers.Values.FirstOrDefault(h =>
                string.Equals(h.MessageName, token, StringComparison.OrdinalIgnoreCase));
            if (byName is not null)
                return byName;
        }
        return null;
    }

    private static string Preview(byte[] body) =>
        body.Length == 0 ? "(空)"
        : Convert.ToHexString(body, 0, Math.Min(body.Length, PreviewBytes))
          + (body.Length > PreviewBytes ? "…" : "");
}
