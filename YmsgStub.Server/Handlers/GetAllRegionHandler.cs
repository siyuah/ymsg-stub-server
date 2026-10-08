using Msg;
using YmsgStub.Server.Http;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 区服列表（9000，HTTP）：GetAllRegion → GetAllRegionAck（LoginModule.RequestHallList）
/// 只返回一个区服，即本 stub。区服名称等显示信息由客户端按 RegionID 查本地配置表，
/// 所以 Region:Id 需要是客户端配置中存在的区服 ID。
/// </summary>
public sealed class GetAllRegionHandler
    : HttpMessageHandlerBase<GetAllRegion, GetAllRegionAck>
{
    public override uint MessageId => MsgIds.GetAllRegion;

    private readonly uint _regionId;
    private readonly int _regionStatus;

    public GetAllRegionHandler(IConfiguration config)
    {
        _regionId     = config.GetValue<uint>("Region:Id", 1);
        _regionStatus = config.GetValue<int>("Region:Status");
    }

    protected override Task<GetAllRegionAck> ProcessAsync(GetAllRegion req)
    {
        var ack = new GetAllRegionAck { RetCode = 0 };
        // 文档没有给出 Lists 的元素类型，按名字推断为 RegionNode
        ack.Lists.Add(new RegionNode
        {
            RegionID  = _regionId,
            Recommend = true,
            // SERVER_STATUS 各取值的含义未知（0 不一定表示"正常"），可用 Region:Status 调整
            Status    = (SERVER_STATUS)_regionStatus,
        });
        return Task.FromResult(ack);
    }
}
