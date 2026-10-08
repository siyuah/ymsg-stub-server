namespace YmsgStub.Server.Http;

/// <summary>
/// HTTP 消息处理器：输入内层请求的 protobuf，返回内层应答的 protobuf
/// （外层 HttpTransMsg 的封装 / 解封由 <see cref="HttpGateway"/> 负责）。
/// </summary>
public interface IHttpMessageHandler
{
    /// <summary>此 handler 负责的消息 ID（HttpTransMsg.MsgID）。</summary>
    uint MessageId { get; }

    Task<byte[]> HandleAsync(byte[] body);
}
