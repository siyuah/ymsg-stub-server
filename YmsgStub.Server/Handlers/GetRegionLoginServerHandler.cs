using Msg;
using YmsgStub.Server.Http;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 区服登录服务器地址（9002，HTTP）：GetRegionLoginServer → GetRegionLoginServerAck
/// 返回本 stub 的 TCP 地址（Server:PublicHost + Server:Port），客户端随后连上该地址并发送 AccountLogin。
/// 客户端不在本机时（手机 / 模拟器），Server:PublicHost 需改成本机的局域网 IP。
/// </summary>
public sealed class GetRegionLoginServerHandler
    : HttpMessageHandlerBase<GetRegionLoginServer, GetRegionLoginServerAck>
{
    public override uint MessageId => MsgIds.GetRegionLoginServer;

    private readonly string _host;
    private readonly uint _port;
    private readonly ILogger<GetRegionLoginServerHandler> _logger;

    public GetRegionLoginServerHandler(IConfiguration config, ILogger<GetRegionLoginServerHandler> logger)
    {
        _host = config["Server:PublicHost"] ?? "127.0.0.1";
        _port = config.GetValue<uint>("Server:Port", 8888);
        _logger = logger;
    }

    protected override Task<GetRegionLoginServerAck> ProcessAsync(GetRegionLoginServer req)
    {
        _logger.LogInformation("GetRegionLoginServer: region={Region} → {Host}:{Port}",
            req.RegionID, _host, _port);

        var ack = new GetRegionLoginServerAck
        {
            RetCode  = 0,
            RegionID = req.RegionID,
            Host     = new ServerHost { IP = _host, Port = _port },
        };
        return Task.FromResult(ack);
    }
}
