using System.Collections.Concurrent;
using Msg;

namespace YmsgStub.Server.Data;

/// <summary>一个角色的完整数据：对应协议里成对出现的 PlayerBase / PlayerSelf。</summary>
public sealed record PlayerRecord(PlayerBase Base, PlayerSelf Self);

/// <summary>
/// 角色存档（仅内存，服务器重启即清空；持久化待实现）。
/// 单机场景下不按账号区分角色：AccessToken 每次登录都可能变化，按它分区会让已建角色"消失"。
/// </summary>
public sealed class PlayerStore
{
    private readonly ConcurrentDictionary<ulong, PlayerRecord> _players = new();
    private readonly ILogger<PlayerStore> _logger;
    private readonly uint _initialMapId;
    private readonly float _initialPosX;
    private readonly float _initialPosY;
    private long _lastPlayerId = 100000;

    public PlayerStore(IConfiguration config, ILogger<PlayerStore> logger)
    {
        _logger = logger;
        _initialMapId = config.GetValue<uint>("Player:InitialMapId");
        _initialPosX  = config.GetValue<float>("Player:InitialPosX");
        _initialPosY  = config.GetValue<float>("Player:InitialPosY");
    }

    public IReadOnlyList<PlayerRecord> All() =>
        _players.Values.OrderBy(p => p.Base.PlayerID).ToList();

    public PlayerRecord? Find(ulong playerId) =>
        _players.TryGetValue(playerId, out var player) ? player : null;

    /// <summary>
    /// 按客户端的创角选择生成一个 1 级角色。只填客户端选择的外观 / 职业和出生位置，
    /// 其余数值保持默认值。
    /// </summary>
    public PlayerRecord Create(CreatePlayer req, long now)
    {
        if (_initialMapId == 0)
            _logger.LogWarning("Player:InitialMapId 未配置（=0），客户端可能无法加载地图；" +
                "请在 appsettings.json 中填入客户端地图配置表中的有效地图 ID");

        ulong id = (ulong)Interlocked.Increment(ref _lastPlayerId);
        var baseInfo = new PlayerBase
        {
            PlayerID       = id,
            PlayerName     = string.IsNullOrEmpty(req.PlayerName) ? $"玩家{id}" : req.PlayerName,
            PlayerLevel    = 1,
            Job            = req.Job,
            Gender         = req.Gender,
            Country        = req.Country,
            Hairstyle      = req.Hairstyle,
            HairstyleColor = req.HairstyleColor,
            LastMapID      = _initialMapId,
            Pos            = new PixelsPos { X = _initialPosX, Y = _initialPosY },

            // proto3 中未设置的子消息在客户端解析后为 null，客户端直接访问其成员就会 NRE。
            // 空实例会被序列化为长度 0 的字段，客户端解析后得到非 null 的默认对象。
            Vip             = new VipBaseInfo(),
            ExpFatigue      = new ExpFatigueData(),
            SkinSet         = new YsSkin(),
            IntimacyEpithet = new IntimacyEpithetNode(),
        };
        var self = new PlayerSelf
        {
            PlayerID  = id,
            LastLogin = now,
        };

        var player = new PlayerRecord(baseInfo, self);
        _players[id] = player;
        return player;
    }
}
