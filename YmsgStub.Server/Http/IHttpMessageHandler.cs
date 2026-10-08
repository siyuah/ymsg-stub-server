namespace YmsgStub.Server.Http;

/// <summary>
/// HTTP 消息处理器：输入内层请求的 protobuf，返回内层应答的 protobuf
/// （HttpTransMsg 的封装 / 解封和按 URL 查找消息由 <see cref="HttpGateway"/> 负责）。
/// </summary>
public interface IHttpMessageHandler
{
    /// <summary>此 handler 负责的消息 ID（HttpTransMsg.MsgID）。</summary>
    uint MessageId { get; }

    /// <summary>请求消息类型名（如 GetAllRegion），未封装的请求可在 URL 中用它指明消息。</summary>
    string MessageName { get; }

    Task<byte[]> HandleAsync(byte[] body);
}
