namespace YmsgStub.Server;

/// <summary>
/// 消息 ID 常量。
/// 真实值需从 MsgIdCs / MsgIdSs Protobuf FileDescriptor 中提取，
/// 此处先用占位值，待后续抓包或 DLL 反射确认后替换。
/// </summary>
public static class MsgIds
{
    // ── C → S ──────────────────────────────────────────────────────────
    public const uint CS_AccountLogin      = 1001;
    public const uint CS_CreateRole        = 1002;
    public const uint CS_EnterGame         = 1003;
    public const uint CS_Heartbeat         = 1004;

    // ── S → C ──────────────────────────────────────────────────────────
    public const uint SC_AccountLoginAck   = 2001;
    public const uint SC_CreateRoleAck     = 2002;
    public const uint SC_EnterGameAck      = 2003;
    public const uint SC_HeartbeatAck      = 2004;

    // TODO: 从 proto_analysis.md 中 MsgIdCs / MsgIdSs 提取真实值后补全
}
