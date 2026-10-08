using Google.Protobuf;

namespace YmsgStub.Server.Http;

/// <summary>
/// HTTP handler 基类，与 TCP 的 MessageHandlerBase 对应。HTTP 请求总有应答，且没有会话。
/// TReq  = 请求消息类型（C→S）
/// TAck  = 应答消息类型（S→C）
/// </summary>
public abstract class HttpMessageHandlerBase<TReq, TAck> : IHttpMessageHandler
    where TReq : IMessage<TReq>, new()
    where TAck : IMessage<TAck>, new()
{
    private static readonly MessageParser<TReq> _parser =
        (MessageParser<TReq>)typeof(TReq)
            .GetProperty("Parser")!
            .GetValue(null)!;

    public abstract uint MessageId { get; }

    public async Task<byte[]> HandleAsync(byte[] body)
    {
        var ack = await ProcessAsync(_parser.ParseFrom(body));
        return ack.ToByteArray();
    }

    protected abstract Task<TAck> ProcessAsync(TReq req);
}
