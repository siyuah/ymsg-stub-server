using System.Buffers.Binary;
using System.Net.Sockets;
using Google.Protobuf;

namespace YmsgStub.Server.Network;

/// <summary>
/// 单个客户端会话。
/// 包格式（待客户端抓包后确认，此处为常见惯例）：
///   [4 bytes] 包总长度（含头）
///   [4 bytes] 消息 ID (uint32)
///   [N bytes] Protobuf body
/// </summary>
public sealed class ClientSession
{
    private readonly TcpClient _tcp;
    private readonly PacketRouter _router;
    private readonly ILogger _logger;
    private readonly CancellationToken _ct;

    // handler 处理当前请求期间排队的推送，在应答之后发出
    private readonly List<(uint msgId, byte[] body)> _pushes = new();

    // 会话级玩家状态，handler 可读写
    public ulong PlayerId { get; set; }
    public string Account { get; set; } = string.Empty;

    public ClientSession(TcpClient tcp, PacketRouter router,
        ILogger logger, CancellationToken ct)
    {
        _tcp = tcp;
        _router = router;
        _logger = logger;
        _ct = ct;
    }

    public async Task RunAsync()
    {
        var endpoint = _tcp.Client.RemoteEndPoint;
        _logger.LogInformation("Client connected: {EP}", endpoint);
        try
        {
            await using var stream = _tcp.GetStream();
            while (!_ct.IsCancellationRequested)
            {
                // 读头部（8 字节）
                var header = new byte[8];
                if (!await ReadExactAsync(stream, header, _ct)) break;

                uint length = BinaryPrimitives.ReadUInt32BigEndian(header.AsSpan(0, 4));
                uint msgId  = BinaryPrimitives.ReadUInt32BigEndian(header.AsSpan(4, 4));

                int bodyLen = (int)length - 8;
                byte[] body = bodyLen > 0 ? new byte[bodyLen] : Array.Empty<byte>();
                if (bodyLen > 0 && !await ReadExactAsync(stream, body, _ct)) break;

                var response = await _router.DispatchAsync(msgId, body, this);
                if (response is not null)
                    await SendAsync(stream, response.Value.msgId, response.Value.body, _ct);

                foreach (var (pushId, pushBody) in _pushes)
                    await SendAsync(stream, pushId, pushBody, _ct);
                _pushes.Clear();
            }
        }
        catch (Exception ex) when (ex is not OperationCanceledException)
        {
            _logger.LogWarning("Session error ({EP}): {Msg}", endpoint, ex.Message);
        }
        finally
        {
            _tcp.Dispose();
            _logger.LogInformation("Client disconnected: {EP}", endpoint);
        }
    }

    /// <summary>
    /// 排队一条推送消息，在当前请求的应答发出之后再发送（保证先 Ack 后推送）。
    /// 只能在 handler 处理请求期间调用。
    /// </summary>
    public void EnqueuePush(uint msgId, IMessage message)
        => _pushes.Add((msgId, message.ToByteArray()));

    private static async Task<bool> ReadExactAsync(
        NetworkStream stream, byte[] buf, CancellationToken ct)
    {
        int read = 0;
        while (read < buf.Length)
        {
            int n = await stream.ReadAsync(buf.AsMemory(read), ct);
            if (n == 0) return false;
            read += n;
        }
        return true;
    }

    private static async Task SendAsync(
        NetworkStream stream, uint msgId, byte[] body, CancellationToken ct)
    {
        uint totalLen = (uint)(8 + body.Length);
        var header = new byte[8];
        BinaryPrimitives.WriteUInt32BigEndian(header.AsSpan(0, 4), totalLen);
        BinaryPrimitives.WriteUInt32BigEndian(header.AsSpan(4, 4), msgId);
        await stream.WriteAsync(header, ct);
        if (body.Length > 0)
            await stream.WriteAsync(body, ct);
    }
}
