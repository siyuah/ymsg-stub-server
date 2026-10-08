namespace YmsgStub.Server;

/// <summary>
/// 消息 ID，从客户端 Msg.MSGID2CS 枚举提取的真实值。
/// 命名规则：
///   无 Ntf 后缀 = 客户端发往服务器（C→S，服务器需要 handle）
///   Ntf 后缀    = 服务器推送给客户端（S→C，服务器主动发送）
/// </summary>
public static class MsgIds
{
    // ── 系统 / 心跳 ─────────────────────────────────────────────────────────
    public const uint AppHeartBeat           = 8;
    public const uint ServerDisconnectNtf    = 9;

    // ── HTTP 登录流程（走 HTTP，不走 TCP，此处仅作记录）─────────────────────
    public const uint HttpRequestToken           = 2001;
    public const uint HttpRequestRegisterAccount = 2002;
    public const uint HttpRequestLoginAccount    = 2003;
    public const uint HttpGetAllRegion           = 9000;
    public const uint HttpGetRegionLoginServer   = 9002;

    // ── 账号 / 区服（TCP）────────────────────────────────────────────────────
    public const uint GetAllRegion           = 9000;
    public const uint GetAllPlayer           = 9001;
    public const uint GetRegionLoginServer   = 9002;
    public const uint CreatePlayer           = 9013;
    public const uint DeletePlayer           = 9014;
    public const uint CancelDeletePlayer     = 9015;
    public const uint AccountLogin           = 9020;
    public const uint AllocateLine           = 9021;
    public const uint GetAllLine             = 9022;
    public const uint SwitchLine             = 9023;
    public const uint SwitchLineNtf          = 9024;
    public const uint CloseServerNtf         = 9025;
    public const uint DailyUpdateNtf         = 9026;
    public const uint SetPlayerName          = 9027;
    public const uint SetPlayerNameNtf       = 9028;

    // ── 时间同步 ─────────────────────────────────────────────────────────────
    public const uint GetServerTime          = 10000;

    // ── 地图 / 进入游戏 ───────────────────────────────────────────────────────
    public const uint EnterMap               = 11005;
    public const uint EnterMapFinish         = 11006;
    public const uint GetPlayerBase          = 11010;
    public const uint BatchGetPlayerBase     = 11011;
    public const uint GetPlayerSelf          = 11012;

    // ── 移动同步 ─────────────────────────────────────────────────────────────
    public const uint StartMove              = 11203;
    public const uint StartMoveNtf           = 11204;
    public const uint StopMove               = 11205;
    public const uint StopMoveNtf            = 11206;
    public const uint SyncToServerNtf        = 11207;
    public const uint SyncPos                = 11409;
    public const uint SyncPosNtf             = 11410;

    // ── 属性 / 状态 ───────────────────────────────────────────────────────────
    public const uint SetAttributeNtf        = 12000;
    public const uint SetStatus              = 12001;
    public const uint SetStatusNtf           = 12002;

    // ── 战斗 / 技能 ───────────────────────────────────────────────────────────
    public const uint UseSkill               = 13001;
    public const uint UseSkillNtf            = 13002;
    public const uint UpdateSkillInstNtf     = 13003;
    public const uint AddBuffNtf             = 13004;
    public const uint DelBuffNtf             = 13005;
    public const uint SetAttackMode          = 13006;
    public const uint GetPlayerSkill         = 13007;
    public const uint UpSkillLevel           = 13012;
    public const uint LearnSkill             = 13013;
    public const uint DeathNotify            = 13185;
    public const uint GetDeathInfo           = 13186;
    public const uint KillNotify             = 13189;

    // ── 背包 / 装备 ───────────────────────────────────────────────────────────
    public const uint GetPlayerPackageData   = 13020;
    public const uint TidyPlayerPackage      = 13021;
    public const uint SellPlayerPackage      = 13022;
    public const uint AddPackageCellNum      = 13027;
    public const uint UseItem                = 13030;
    public const uint DecomposeItem          = 13031;
    public const uint DestroyItem            = 13032;
    public const uint WearEquip              = 13033;
    public const uint EnhanceEquip           = 13034;
    public const uint WearEquipNtf           = 13051;
    public const uint GetAllAttribute        = 13041;
    public const uint PickupItem             = 13042;
    public const uint PickupItemNtf          = 13043;
    public const uint ConfirmRebirth         = 13045;
    public const uint PlayerAddExpNtf        = 13039;
    public const uint PlayerManualUpLv       = 13040;
    public const uint ChangeHpCurrentNtf     = 13049;

    // ── 聊天 ─────────────────────────────────────────────────────────────────
    public const uint SendChat               = 13057;
    public const uint SendChatMessageNtf     = 13058;
    public const uint GetChatList            = 13060;
    public const uint SetChatLastReadNum     = 13076;

    // ── 任务 ─────────────────────────────────────────────────────────────────
    public const uint GetTaskList            = 13070;
    public const uint SetTaskFollow          = 13071;
    public const uint GetTaskAward           = 13072;
    public const uint GetOneTask             = 13073;
    public const uint AbandonTask            = 13077;
    public const uint AbandonTaskNtf         = 13078;
    public const uint UpdateTaskNtf          = 13079;

    // ── 邮件 ─────────────────────────────────────────────────────────────────
    public const uint GetMailList            = 13090;
    public const uint SetReadMail            = 13092;
    public const uint GetAwardMail           = 13093;
    public const uint GetAllAwardMail        = 13094;
    public const uint DeleteMail             = 13095;
    public const uint AddMailNtf             = 13097;

    // ── 商店 ─────────────────────────────────────────────────────────────────
    public const uint GetGoodsList           = 13100;
    public const uint BuyShopGoods           = 13101;

    // ── 队伍 ─────────────────────────────────────────────────────────────────
    public const uint GetTeamList            = 13125;
    public const uint CreatTeam              = 13127;
    public const uint OptTeamExit            = 13133;
    public const uint OptTeamSendInvite      = 13135;
    public const uint OptTeamInvite          = 13137;
    public const uint CallMembersTeam        = 13139;

    // ── 副本 ─────────────────────────────────────────────────────────────────
    public const uint CreateTeamDungeon      = 13149;
    public const uint ChallengeDungeon       = 13150;
    public const uint ExitDungeon            = 20001;
    public const uint ExitDungeonNtf         = 20002;

    // ── 活跃度 / 签到 ─────────────────────────────────────────────────────────
    public const uint GetVitality            = 20100;
    public const uint UpdateVitalityNtf      = 20101;
    public const uint ClaimWelfare           = 20103;
    public const uint ClaimVitality          = 20104;
    public const uint GetSignInData          = 26000;
    public const uint DailySignIn            = 26001;

    // ── 称号 ─────────────────────────────────────────────────────────────────
    public const uint GetEpithet             = 20200;
    public const uint SetEpithet             = 20201;
    public const uint SetEpithetNtf          = 20202;

    // ── 交易 ─────────────────────────────────────────────────────────────────
    public const uint ApplyTrade             = 13200;
    public const uint OptApplyTrade          = 13202;
    public const uint LockTrade              = 13204;
    public const uint ConfirmTrade           = 13206;
    public const uint CancelTrade            = 13208;

    // ── 好友 / 关系 ───────────────────────────────────────────────────────────
    public const uint GetRelationshipIdList  = 29500;
    public const uint GetRelationshipList    = 29502;
    public const uint ApplyAddRelationship   = 29505;
    public const uint DelRelationship        = 29510;

    // ── 军团 ─────────────────────────────────────────────────────────────────
    public const uint LegionCreate           = 30001;  // OPERATE_TYPE value
    public const uint GetLegionInfo          = 21000;  // placeholder — confirm via packet capture

    // ── 元神 ─────────────────────────────────────────────────────────────────
    public const uint ActivateYuanShen       = 27002;
    public const uint ActivateYuanShenNtf    = 27003;

    // ── 排行榜 ───────────────────────────────────────────────────────────────
    public const uint GetRankData            = 25000;
    public const uint GetAllRanking          = 25001;

    // ── 充值 / VIP ────────────────────────────────────────────────────────────
    public const uint GetRechargeData        = 25512;
    public const uint CreatePayOrder         = 25600;

    // ── 双倍经验 ─────────────────────────────────────────────────────────────
    public const uint RestartDoubleExpButton = 24500;
    public const uint PauseDoubleExpButton   = 24501;
    public const uint GetDailyDoubleExpTime  = 24505;

    // ── 采集 ─────────────────────────────────────────────────────────────────
    public const uint RequestStartGather     = 24102;
    public const uint RequestStopGather      = 24103;
    public const uint RequestGetGatherAward  = 24105;
}
