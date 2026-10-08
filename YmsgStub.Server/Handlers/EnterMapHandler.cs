using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 进入地图（即进入游戏）：C→S EnterMap → S→C EnterMapAck，随后推送 EnterMapFinishNtfAck。
/// EnterMapFinishNtfAck 在协议里没有对应的 C→S 请求，推测是服务器在玩家进入地图后主动下发，
/// 这里紧跟在 EnterMapAck 之后发送；实际时机待抓包确认。
/// </summary>
public sealed class EnterMapHandler
    : MessageHandlerBase<EnterMap, EnterMapAck>
{
    public override uint MessageId => MsgIds.CS_EnterMap;
    protected override uint AckId   => MsgIds.SC_EnterMapAck;

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
            // 存档只在内存里，服务器重启后客户端若带着旧角色 ID 重连会走到这里
            _logger.LogWarning("EnterMap: unknown playerId {Id}", req.PlayerID);
            return Task.FromResult<EnterMapAck?>(new EnterMapAck
            {
                RetCode   = RetFailed,
                EnterType = req.EnterType,
            });
        }

        long now = ServerClock.NowLike(req.Time);
        player.Self.LastLogin = now;
        session.PlayerId = req.PlayerID;

        var ack = new EnterMapAck
        {
            RetCode   = 0,
            EnterType = req.EnterType,
            InitTime  = now,
            BaseInfo  = player.Base.Clone(),
            SelfInfo  = player.Self.Clone(),
        };
        session.EnqueuePush(MsgIds.SC_EnterMapFinishNtfAck, new EnterMapFinishNtfAck { RetCode = 0 });

        _logger.LogInformation("EnterMap: playerId={Id}, enterType={Type}, mapId={Map}",
            req.PlayerID, req.EnterType, player.Base.LastMapID);
        return Task.FromResult<EnterMapAck?>(ack);
    }
}
