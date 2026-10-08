using Msg;
using YmsgStub.Server.Network;

namespace YmsgStub.Server.Handlers;

/// <summary>
/// 服务器时间（10000）：C→S GetServerTime → S→C GetServerTimeAck（LoginModule.RequestServerTime）
/// ServerTime 为当前 Unix 时间戳，单位跟随客户端 ClientTime（秒 / 毫秒），并由此确定其他消息
/// 下发时间戳的单位（见 <see cref="ServerClock"/>）；ClientTime 原样回传，供客户端计算往返延迟。
/// </summary>
public sealed class GetServerTimeHandler
    : MessageHandlerBase<GetServerTime, GetServerTimeAck>
{
    public override uint MessageId => MsgIds.GetServerTime;

    protected override Task<GetServerTimeAck?> ProcessAsync(
        GetServerTime req, ClientSession session)
    {
        ServerClock.LearnUnit(req.ClientTime);
        var ack = new GetServerTimeAck
        {
            RetCode    = 0,
            ClientTime = req.ClientTime,
            ServerTime = ServerClock.Now(req.ClientTime),
        };
        return Task.FromResult<GetServerTimeAck?>(ack);
    }
}
