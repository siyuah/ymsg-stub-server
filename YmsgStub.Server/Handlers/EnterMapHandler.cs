using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 进入地图（11005，即进入游戏）：C→S EnterMap → S→C EnterMapAck（UIRoleSelect.RequestEnterMap），
/// 随后推送 EnterMapFinish（11006）。
/// 返回角色的 BaseInfo / SelfInfo，地图由其中的 LastMapID / Pos 决定。
///
/// 11006 虽然没有 Ntf 后缀，但应是服务器推送：它的 body EnterMapFinishNtfAck 属于 XxxNtfAck，
/// 而本协议中方向可判断的 XxxNtfAck 都是推送体；协议里也没有对应的请求类型（空请求在本协议中
/// 也会定义类型，如 FinishTransportGoodsInfo）。DeathNotify / KillNotify 同样没有 Ntf 后缀却是推送。
/// 若实测客户端会主动发 11006（见 <see cref="EnterMapFinishHandler"/> 的日志），
/// 可将 Protocol:PushEnterMapFinish 设为 false 关闭推送。
/// </summary>
public sealed class EnterMapHandler
    : MessageHandlerBase<EnterMap, EnterMapAck>
{
    public override uint MessageId => MsgIds.EnterMap;

    private readonly PlayerStore _players;
    private readonly bool _pushEnterMapFinish;
    private readonly ILogger<EnterMapHandler> _logger;

    public EnterMapHandler(PlayerStore players, IConfiguration config, ILogger<EnterMapHandler> logger)
    {
        _players = players;
        _pushEnterMapFinish = config.GetValue("Protocol:PushEnterMapFinish", true);
        _logger = logger;
    }

    protected override Task<EnterMapAck?> ProcessAsync(
        EnterMap req, ClientSession session)
    {
        var player = _players.Find(req.PlayerID);
        if (player is null)
        {
            // 存档文件被删除或更换后，客户端若带着旧角色 ID 重连会走到这里
            _logger.LogWarning("EnterMap: unknown playerId {Id}", req.PlayerID);
            return Task.FromResult<EnterMapAck?>(new EnterMapAck
            {
                RetCode   = RetFailed,
                EnterType = req.EnterType,
            });
        }

        long now = ServerClock.Now(req.Time);
        _players.PrepareEnterMap(player, now);
        session.PlayerId = req.PlayerID;
        if (player.MapId == 0)
            _logger.LogWarning("EnterMap: playerId={Id} 的地图 ID 为 0，客户端可能无法加载地图；" +
                "请配置 Player:InitialMapId", req.PlayerID);

        var ack = new EnterMapAck
        {
            RetCode   = 0,
            EnterType = req.EnterType,
            InitTime  = now,
            BaseInfo  = player.ToPlayerBase(),
            SelfInfo  = player.ToPlayerSelf(),
        };
        if (_pushEnterMapFinish)
            session.EnqueuePush(MsgIds.EnterMapFinish, new EnterMapFinishNtfAck { RetCode = 0 });

        _logger.LogInformation("EnterMap: playerId={Id}, enterType={Type}, mapId={Map}",
            req.PlayerID, req.EnterType, player.MapId);
        return Task.FromResult<EnterMapAck?>(ack);
    }
}
