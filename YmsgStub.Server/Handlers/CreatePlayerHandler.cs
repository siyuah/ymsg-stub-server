using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 创建角色（9013）：C→S CreatePlayer → S→C CreatePlayerAck（PlayerModule.RequestCreateRole）
/// 新角色写入本地 JSON 存档。协议里没有单独的"选择角色"消息：选角是客户端行为，选中后直接发 EnterMap。
/// </summary>
public sealed class CreatePlayerHandler
    : MessageHandlerBase<CreatePlayer, CreatePlayerAck>
{
    public override uint MessageId => MsgIds.CreatePlayer;

    private readonly PlayerStore _players;
    private readonly ILogger<CreatePlayerHandler> _logger;

    public CreatePlayerHandler(PlayerStore players, ILogger<CreatePlayerHandler> logger)
    {
        _players = players;
        _logger = logger;
    }

    protected override Task<CreatePlayerAck?> ProcessAsync(
        CreatePlayer req, ClientSession session)
    {
        var player = _players.Create(req, ServerClock.NowLike(req.Time));
        _logger.LogInformation("CreatePlayer: id={Id}, name={Name}, job={Job}, gender={Gender}, country={Country}",
            player.PlayerId, player.Name, req.Job, req.Gender, req.Country);

        var ack = new CreatePlayerAck
        {
            RetCode  = 0,
            Account  = session.Account,
            PlayerID = player.PlayerId,
            BaseInfo = player.ToPlayerBase(),
            SelfInfo = player.ToPlayerSelf(),
        };
        return Task.FromResult<CreatePlayerAck?>(ack);
    }
}
