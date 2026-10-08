namespace YmsgStub.Server;

/// <summary>
/// 服务器时间。协议里时间戳的单位（秒 / 毫秒）尚未确认：以 GetServerTime.ClientTime
/// （客户端本地时钟）为准记下单位，之后所有下发的时间戳都用同一单位；
/// 在此之前按各请求自带的时间戳推断，都没有时按秒。
/// </summary>
public static class ServerClock
{
    // 1e11 按秒算是公元 5138 年，按毫秒算是 1973 年，足以区分两种单位
    private const long MillisecondThreshold = 100_000_000_000;

    private const int Unknown = 0, Seconds = 1, Milliseconds = 2;
    private static int _unit = Unknown;

    /// <summary>根据客户端本地时钟（GetServerTime.ClientTime）记下时间戳单位。</summary>
    public static void LearnUnit(long clientClock)
    {
        if (clientClock > 0)
            Volatile.Write(ref _unit, clientClock >= MillisecondThreshold ? Milliseconds : Seconds);
    }

    /// <summary>
    /// 当前 Unix 时间。单位已由 <see cref="LearnUnit"/> 确定时用该单位，
    /// 否则按 <paramref name="clientSample"/>（请求里的时间戳）推断，样本为 0 时按秒。
    /// </summary>
    public static long Now(long clientSample = 0)
    {
        int unit = Volatile.Read(ref _unit);
        bool ms = unit == Unknown ? clientSample >= MillisecondThreshold : unit == Milliseconds;
        return ms
            ? DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            : DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }
}
