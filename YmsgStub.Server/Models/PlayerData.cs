using Msg;

namespace YmsgStub.Server.Models;

/// <summary>
/// 角色存档（保存在本地 JSON 文件中）。只保存 stub 用到的字段，
/// 发给客户端时再转换成协议里的 PlayerBase / PlayerSelf。
/// 职业 / 性别 / 国家按整数保存：客户端枚举的成员名未知，整数值可以无损往返。
/// </summary>
public sealed class PlayerData
{
    public ulong  PlayerId       { get; set; }
    public string Name           { get; set; } = string.Empty;
    public uint   Level          { get; set; } = 1;
    public int    Job            { get; set; }
    public int    Gender         { get; set; }
    public int    Country        { get; set; }
    public uint   Hairstyle      { get; set; }
    public uint   HairstyleColor { get; set; }
    public uint   MapId          { get; set; }
    public float  PosX           { get; set; }
    public float  PosY           { get; set; }
    public long   LastLogin      { get; set; }

    public PlayerBase ToPlayerBase() => new()
    {
        PlayerID       = PlayerId,
        PlayerName     = Name,
        PlayerLevel    = Level,
        Job            = (JOB_TYPE)Job,
        Gender         = (GENDER_TYPE)Gender,
        Country        = (COUNTRY_TYPE)Country,
        Hairstyle      = Hairstyle,
        HairstyleColor = HairstyleColor,
        LastMapID      = MapId,
        Pos            = new PixelsPos { X = PosX, Y = PosY },

        // proto3 中未设置的子消息在客户端解析后为 null，客户端直接访问其成员就会 NRE。
        // 空实例会被序列化为长度 0 的字段，客户端解析后得到非 null 的默认对象。
        Vip             = new VipBaseInfo(),
        ExpFatigue      = new ExpFatigueData(),
        SkinSet         = new YsSkin(),
        IntimacyEpithet = new IntimacyEpithetNode(),
    };

    public PlayerSelf ToPlayerSelf() => new()
    {
        PlayerID  = PlayerId,
        LastLogin = LastLogin,
    };

    /// <summary>区服选择界面用的角色摘要（GetAllPlayerAck.Lists）。</summary>
    public PlayerNode ToPlayerNode(uint regionId) => new()
    {
        PlayerID   = PlayerId,
        PlayerName = Name,
        PlayerLv   = Level,
        Job        = (JOB_TYPE)Job,
        Gender     = (GENDER_TYPE)Gender,
        LastLogin  = LastLogin,
        RegionID   = regionId,
    };
}
