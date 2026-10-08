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

    /// <summary>通用失败的 RetCode。ERROR_CODE 枚举的取值未知，先用 1。</summary>
    protected const uint RetFailed = 1;

    public abstract uint MessageId { get; }

    /// <summary>
    /// 应答的消息 ID。MSGID2CS 中没有单独的 Ack 项，应答与请求共用同一个 ID
    /// （如 AccountLogin 请求和 AccountLoginAck 应答都是 9020），一般无需重写。
    /// </summary>
    protected virtual uint AckId => MessageId;

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
