using Msg;
using YmsgStub.Server.Data;
using YmsgStub.Server.Http;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 各区服的角色列表（9001，HTTP）：GetAllPlayer → GetAllPlayerAck（LoginModule.RequestHallRoles）
/// 与 GetAllRegion / GetRegionLoginServer 一样只带 Token、ID 夹在两者之间，推测同样走 HTTP（待确认）。
/// 所有角色都属于唯一的区服 Region:Id。
/// </summary>
public sealed class GetAllPlayerHandler
    : HttpMessageHandlerBase<GetAllPlayer, GetAllPlayerAck>
{
    public override uint MessageId => MsgIds.GetAllPlayer;

    private readonly PlayerStore _players;
    private readonly uint _regionId;

    public GetAllPlayerHandler(PlayerStore players, IConfiguration config)
    {
        _players  = players;
        _regionId = config.GetValue<uint>("Region:Id", 1);
    }

    protected override Task<GetAllPlayerAck> ProcessAsync(GetAllPlayer req)
    {
        var ack = new GetAllPlayerAck { RetCode = 0 };
        // 文档没有给出 Lists 的元素类型，推断为 PlayerNode：带 RegionID / LastLogin，且不在别处作单个字段使用
        foreach (var player in _players.All())
            ack.Lists.Add(player.ToPlayerNode(_regionId));
        return Task.FromResult(ack);
    }
}
