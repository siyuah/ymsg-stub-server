namespace YmsgStub.Server.Network;

/// <summary>
/// 消息路由表：msgId → handler。
/// </summary>
public sealed class PacketRouter
{
    private readonly ILogger<PacketRouter> _logger;
    private readonly Dictionary<uint, IMessageHandler> _handlers = new();

    public PacketRouter(ILogger<PacketRouter> logger) => _logger = logger;

    public void RegisterAll(IServiceProvider services)
    {
        foreach (var handler in services.GetServices<IMessageHandler>())
        {
            if (_handlers.TryAdd(handler.MessageId, handler))
                _logger.LogDebug("Registered handler {Name} for msgId {Id} ({MsgName})",
                    handler.GetType().Name, handler.MessageId,
                    MsgIdCatalog.Describe(handler.MessageId) ?? "不在 DLL 枚举中");
            else
                _logger.LogWarning("Duplicate handler for msgId {Id}: {Name}",
                    handler.MessageId, handler.GetType().Name);
        }

        if (_handlers.Count == 0)
            _logger.LogWarning("PacketRouter: 0 handlers registered — 游戏 DLL 可能没有正确加载");
        else
            _logger.LogInformation("PacketRouter: {Count} handlers registered", _handlers.Count);

        if (MsgIdCatalog.IsAvailable)
        {
            int unknown = _handlers.Keys.Count(id => MsgIdCatalog.Describe(id) is null);
            if (unknown > 0)
                _logger.LogWarning("{Count} 个 handler 的 msgId 不在客户端 MSGID 枚举中，" +
                    "MsgIds.cs 可能仍是占位值（运行 `dotnet run -- --dump-msgids` 获取真实值）", unknown);
        }
    }

    public async Task<(uint msgId, byte[] body)?> DispatchAsync(
        uint msgId, byte[] body, ClientSession session)
    {
        if (_handlers.TryGetValue(msgId, out var handler))
        {
            try { return await handler.HandleAsync(body, session); }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Handler error for msgId {Id}", msgId);
                return null;
            }
        }

        _logger.LogWarning("No handler for msgId {Id} ({MsgName}, body {Len} bytes)",
            msgId, MsgIdCatalog.Describe(msgId) ?? "未知", body.Length);
        return null;
    }
}
