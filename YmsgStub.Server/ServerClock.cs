namespace YmsgStub.Server;

/// <summary>
/// 服务器时间。协议里时间戳的单位（秒 / 毫秒）尚未确认，
/// 这里按客户端请求里自带的时间戳推断单位，回包使用同一单位。
/// </summary>
public static class ServerClock
{
    // 1e11 按秒算是公元 5138 年，按毫秒算是 1973 年，足以区分两种单位
    private const long MillisecondThreshold = 100_000_000_000;

    /// <summary>
    /// 返回当前 Unix 时间，单位与 <paramref name="clientSample"/> 一致；
    /// 样本为 0（客户端没填）时按秒返回。
    /// </summary>
    public static long NowLike(long clientSample) =>
        clientSample >= MillisecondThreshold
            ? DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            : DateTimeOffset.UtcNow.ToUnixTimeSeconds();
}
