using Google.Protobuf;

namespace YmsgStub.Server.Network;

/// <summary>
/// 基类：减少每个 handler 的模板代码。
/// TReq  = 请求消息类型（C→S）
/// TAck  = 应答消息类型（S→C）
/// </summary>
public abstract class MessageHandlerBase<TReq, TAck> : IMessageHandler
    where TReq : IMessage<TReq>, new()
    where TAck : IMessage<TAck>, new()
{
    private static readonly MessageParser<TReq> _parser =
        (MessageParser<TReq>)typeof(TReq)
            .GetProperty("Parser")!
            .GetValue(null)!;

    public abstract uint MessageId { get; }
    protected abstract uint AckId { get; }

    public async Task<(uint msgId, byte[] body)?> HandleAsync(
        byte[] body, ClientSession session)
    {
        var req = _parser.ParseFrom(body);
        var ack = await ProcessAsync(req, session);
        if (ack is null) return null;
        return (AckId, ack.ToByteArray());
    }

    protected abstract Task<TAck?> ProcessAsync(TReq req, ClientSession session);
}
