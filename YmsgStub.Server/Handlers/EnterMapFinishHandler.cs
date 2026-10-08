using Google.Protobuf;
using Msg;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 地图加载完成（11006）：正常情况下这是服务器在 EnterMapAck 之后的推送（见 <see cref="EnterMapHandler"/>）。
/// 这里兜底处理客户端主动发来 11006 的情况：同样回 EnterMapFinishNtfAck，并打警告日志——
/// 出现这条日志说明 11006 实际是客户端请求，可以关闭 Protocol:PushEnterMapFinish。
/// 协议里没有 EnterMapFinish 请求类型，因此直接实现 IMessageHandler，不解析请求。
/// </summary>
public sealed class EnterMapFinishHandler : IMessageHandler
{
    public uint MessageId => MsgIds.EnterMapFinish;

    private static readonly byte[] _ack = new EnterMapFinishNtfAck { RetCode = 0 }.ToByteArray();

    private readonly ILogger<EnterMapFinishHandler> _logger;

    public EnterMapFinishHandler(ILogger<EnterMapFinishHandler> logger)
        => _logger = logger;

    public Task<(uint msgId, byte[] body)?> HandleAsync(byte[] body, ClientSession session)
    {
        _logger.LogWarning("客户端主动发送了 EnterMapFinish（11006，body {Len} bytes）：11006 是 C→S 请求，" +
            "可将 Protocol:PushEnterMapFinish 设为 false", body.Length);
        return Task.FromResult<(uint msgId, byte[] body)?>((MessageId, _ack));
    }
}
