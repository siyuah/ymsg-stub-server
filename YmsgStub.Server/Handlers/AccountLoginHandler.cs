using Msg;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 账号登录：C→S AccountLogin → S→C AccountLoginAck
/// 暂时返回成功，角色列表为空，等后续角色系统实现后补充。
/// </summary>
public sealed class AccountLoginHandler
    : MessageHandlerBase<AccountLogin, AccountLoginAck>
{
    // TODO: 从 MsgIdCs 提取真实枚举值后更新这两个常量
    public override uint MessageId => MsgIds.CS_AccountLogin;
    protected override uint AckId   => MsgIds.SC_AccountLoginAck;

    private readonly ILogger<AccountLoginHandler> _logger;

    public AccountLoginHandler(ILogger<AccountLoginHandler> logger)
        => _logger = logger;

    protected override Task<AccountLoginAck?> ProcessAsync(
        AccountLogin req, ClientSession session)
    {
        _logger.LogInformation("AccountLogin: osType={OS}", req.OsType);

        // TODO: 验证 AccessToken / Sign
        session.Account = req.AccessToken;

        var ack = new AccountLoginAck
        {
            RetCode = 0,
            Account = req.AccessToken,
        };
        // BaseLists / SelfLists 留空，客户端应跳到角色选择界面
        return Task.FromResult<AccountLoginAck?>(ack);
    }
}
