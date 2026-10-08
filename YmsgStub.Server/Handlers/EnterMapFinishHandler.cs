using Google.Protobuf;
using Msg;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 地图加载完成（11006）：C→S EnterMapFinish → S→C EnterMapFinishNtfAck
/// 枚举名没有 Ntf 后缀，按"无 Ntf = 客户端请求"的规则，这是客户端收到 EnterMapAck、
/// 加载完场景后发来的；服务器不应在 EnterMapAck 之后主动推送。
/// 协议里没有 EnterMapFinish 请求类型（推测 body 为空），因此直接实现 IMessageHandler，不解析请求。
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
        _logger.LogInformation("EnterMapFinish: playerId={Id} 已进入地图", session.PlayerId);
        return Task.FromResult<(uint msgId, byte[] body)?>((MessageId, _ack));
    }
}
