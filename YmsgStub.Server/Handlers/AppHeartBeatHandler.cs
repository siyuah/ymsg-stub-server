using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 心跳（8）：协议里没有心跳的消息类型。回一个空 body，避免客户端因收不到回包而判定断线、
/// 触发重连（SocketHandler.StartReconnect）。不原样回传：客户端若用别的类型解析回包，
/// 请求里的字段（如时间戳）可能被误读成 RetCode；空 body 能解析成任意类型且 RetCode=0。
/// </summary>
public sealed class AppHeartBeatHandler : IMessageHandler
{
    public uint MessageId => MsgIds.AppHeartBeat;

    private readonly ILogger<AppHeartBeatHandler> _logger;

    public AppHeartBeatHandler(ILogger<AppHeartBeatHandler> logger)
        => _logger = logger;

    public Task<(uint msgId, byte[] body)?> HandleAsync(byte[] body, ClientSession session)
    {
        // 心跳很频繁，用 Trace 级别；需要确认客户端心跳内容时再打开
        _logger.LogTrace("AppHeartBeat: body {Len} bytes {Hex}", body.Length, Convert.ToHexString(body));
        return Task.FromResult<(uint msgId, byte[] body)?>((MessageId, Array.Empty<byte>()));
    }
}
