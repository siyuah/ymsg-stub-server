using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 心跳（8）：协议里没有心跳的消息类型，原样回传客户端发来的 body，
/// 避免客户端因收不到回包而判定断线、触发重连（SocketHandler.StartReconnect）。
/// </summary>
public sealed class AppHeartBeatHandler : IMessageHandler
{
    public uint MessageId => MsgIds.AppHeartBeat;

    public Task<(uint msgId, byte[] body)?> HandleAsync(byte[] body, ClientSession session)
        => Task.FromResult<(uint msgId, byte[] body)?>((MessageId, body));
}
