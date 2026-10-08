using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 进入地图（11005，即进入游戏）：C→S EnterMap → S→C EnterMapAck（UIRoleSelect.RequestEnterMap）
/// 返回角色的 BaseInfo / SelfInfo，地图由其中的 LastMapID / Pos 决定。
/// 客户端加载完场景后会再发 EnterMapFinish（11006），见 <see cref="EnterMapFinishHandler"/>。
/// </summary>
public sealed class EnterMapHandler
    : MessageHandlerBase<EnterMap, EnterMapAck>
{
    public override uint MessageId => MsgIds.EnterMap;

    // ERROR_CODE 枚举的取值未知，先用 1 表示通用失败
    private const uint RetFailed = 1;

    private readonly PlayerStore _players;
    private readonly ILogger<EnterMapHandler> _logger;

    public EnterMapHandler(PlayerStore players, ILogger<EnterMapHandler> logger)
    {
        _players = players;
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

        long now = ServerClock.NowLike(req.Time);
        _players.UpdateLastLogin(player, now);
        session.PlayerId = req.PlayerID;

        var ack = new EnterMapAck
        {
            RetCode   = 0,
            EnterType = req.EnterType,
            InitTime  = now,
            BaseInfo  = player.ToPlayerBase(),
            SelfInfo  = player.ToPlayerSelf(),
        };
        _logger.LogInformation("EnterMap: playerId={Id}, enterType={Type}, mapId={Map}",
            req.PlayerID, req.EnterType, player.MapId);
        return Task.FromResult<EnterMapAck?>(ack);
    }
}
