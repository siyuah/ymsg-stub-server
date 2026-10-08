using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 账号登录（9020）：C→S AccountLogin → S→C AccountLoginAck
/// 单机 stub 不校验 AccessToken / Sign，直接返回成功和本地存档中的角色列表；
/// 列表为空时客户端应进入创建角色界面。
/// </summary>
public sealed class AccountLoginHandler
    : MessageHandlerBase<AccountLogin, AccountLoginAck>
{
    public override uint MessageId => MsgIds.AccountLogin;

    private readonly PlayerStore _players;
    private readonly ILogger<AccountLoginHandler> _logger;

    public AccountLoginHandler(PlayerStore players, ILogger<AccountLoginHandler> logger)
    {
        _players = players;
        _logger = logger;
    }

    protected override Task<AccountLoginAck?> ProcessAsync(
        AccountLogin req, ClientSession session)
    {
        session.Account = req.AccessToken;

        var ack = new AccountLoginAck
        {
            RetCode = 0,
            Account = req.AccessToken,
        };
        // BaseLists / SelfLists 按下标一一对应。文档没有给出 RepeatedField 的元素类型，
        // 这里按字段名和 CreatePlayerAck.BaseInfo / SelfInfo 推断为 PlayerBase / PlayerSelf。
        foreach (var player in _players.All())
        {
            ack.BaseLists.Add(player.ToPlayerBase());
            ack.SelfLists.Add(player.ToPlayerSelf());
        }

        _logger.LogInformation("AccountLogin: osType={OS}, roles={Count}",
            req.OsType, ack.BaseLists.Count);
        return Task.FromResult<AccountLoginAck?>(ack);
    }
}
