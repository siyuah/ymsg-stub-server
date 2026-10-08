namespace YmsgStub.Server;

/// <summary>
/// 消息 ID 常量。
///
/// ⚠ 下列数值仍是占位值，不是客户端真实 ID：
/// docs/proto_analysis.md 的「消息 ID」一节只导出了 MsgIdCsReflection / MsgIdSsReflection
/// 两个描述符容器类（IsEnum=False），没有任何枚举值。真正的枚举是 MSGID2CS
/// （客户端 NetworkManager.RegisterMessageHandler(MSGID2CS msgID, ...) 的参数类型），
/// 名字全大写，没被 "MsgId*" 的筛选匹配到。
/// 另外 MsgIdSs 很可能是服务器之间（SS）的消息，协议里的 SSTestOnline / SSSetYueKaTime 即属此类；
/// 客户端收发的请求和应答应该都在 MSGID2CS 里。
///
/// 回填方法：把游戏 DLL 放进 libs/ 后运行
///     dotnet run -- --dump-msgids
/// 按导出结果替换下面的数值。服务器启动时也会把每个 handler 的 msgId
/// 对照 DLL 中的 MSGID 枚举打印出来，可据此核对。
///
/// 命名：CS_ = 客户端发出的请求，SC_ = 服务器发出的应答 / 推送，
/// 后缀与 docs/proto_analysis.md 中的消息类型名一致。
/// </summary>
public static class MsgIds
{
    // ── 登录 ───────────────────────────────────────────────────────────
    public const uint CS_AccountLogin         = 1001;
    public const uint SC_AccountLoginAck      = 2001;

    // ── 创建角色（选角是客户端行为，选中后直接发 EnterMap）────────────
    public const uint CS_CreatePlayer         = 1002;
    public const uint SC_CreatePlayerAck      = 2002;

    // ── 进入地图（即进入游戏）─────────────────────────────────────────
    public const uint CS_EnterMap             = 1003;
    public const uint SC_EnterMapAck          = 2003;
    public const uint SC_EnterMapFinishNtfAck = 2004;

    // ── 服务器时间（LoginModule.RequestServerTime）────────────────────
    public const uint CS_GetServerTime        = 1004;
    public const uint SC_GetServerTimeAck     = 2005;
}
