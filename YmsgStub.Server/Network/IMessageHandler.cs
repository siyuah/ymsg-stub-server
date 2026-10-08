using Google.Protobuf;

namespace YmsgStub.Server.Network;

/// <summary>
/// 消息处理器接口。每个模块实现一组 handler。
/// </summary>
public interface IMessageHandler
{
    /// <summary>此 handler 负责的消息 ID（C→S 方向）。</summary>
    uint MessageId { get; }

    /// <summary>
    /// 处理请求，返回应答消息的 (msgId, body)；
    /// 返回 null 表示无需回复（如广播已在内部处理）。
    /// </summary>
    Task<(uint msgId, byte[] body)?> HandleAsync(byte[] body, ClientSession session);
}
