using System.Net;
using System.Net.Sockets;

namespace YmsgStub.Server.Network;

/// <summary>
/// TCP 服务器：监听客户端连接，每个连接交给 ClientSession 处理。
/// </summary>
public sealed class GameServer : BackgroundService
{
    private readonly ILogger<GameServer> _logger;
    private readonly PacketRouter _router;
    private readonly IConfiguration _config;

    public GameServer(ILogger<GameServer> logger, PacketRouter router, IConfiguration config)
    {
        _logger = logger;
        _router = router;
        _config = config;
    }

    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        int port = _config.GetValue<int>("Server:Port", 8888);
        var listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        _logger.LogInformation("YMSG stub server listening on port {Port}", port);

        while (!ct.IsCancellationRequested)
        {
            TcpClient client;
            try { client = await listener.AcceptTcpClientAsync(ct); }
            catch (OperationCanceledException) { break; }

            _ = Task.Run(() => new ClientSession(client, _router,
                _logger, ct).RunAsync(), ct);
        }

        listener.Stop();
    }
}
