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
                _logger.LogDebug("Registered handler {Name} for msgId {Id}",
                    handler.GetType().Name, handler.MessageId);
            else
                _logger.LogWarning("Duplicate handler for msgId {Id}: {Name}",
                    handler.MessageId, handler.GetType().Name);
        }
        _logger.LogInformation("PacketRouter: {Count} handlers registered", _handlers.Count);
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

        _logger.LogWarning("No handler for msgId {Id} (body {Len} bytes)", msgId, body.Length);
        return null;
    }
}
