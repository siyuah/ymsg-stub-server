using Msg;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 服务器时间：C→S GetServerTime → S→C GetServerTimeAck（LoginModule.RequestServerTime）
/// ClientTime 原样回传，供客户端计算往返延迟。
/// </summary>
public sealed class GetServerTimeHandler
    : MessageHandlerBase<GetServerTime, GetServerTimeAck>
{
    public override uint MessageId => MsgIds.CS_GetServerTime;
    protected override uint AckId   => MsgIds.SC_GetServerTimeAck;

    protected override Task<GetServerTimeAck?> ProcessAsync(
        GetServerTime req, ClientSession session)
    {
        var ack = new GetServerTimeAck
        {
            RetCode    = 0,
            ClientTime = req.ClientTime,
            ServerTime = ServerClock.NowLike(req.ClientTime),
        };
        return Task.FromResult<GetServerTimeAck?>(ack);
    }
}
