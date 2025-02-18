using System;
using System.Diagnostics;

public class ProfilingUtils
{
    public static long GetTotalMemory(long memoryBefore)
    {
        return GC.GetTotalMemory(true) - memoryBefore;
    }

    public static string TotalMemoryMB(long memoryBefore)
    {
        return $"{GetTotalMemory(memoryBefore) / 1_048_576f:N1}MB";
    }

    public static string TotalMemoryKB(long memoryBefore)
    {
        return $"{(GetTotalMemory(memoryBefore) - memoryBefore) * 1000 / 1_048_576f:N1}KB";
    }

    public static Stopwatch StartTimer()
    {
        var timer = new Stopwatch();
        timer.Start();
        return timer;
    }

    public static string TimeFormat(Stopwatch timer, string format = @"hh\:mm\:ss")
    {
        return TimeSpan.FromSeconds(timer.ElapsedMilliseconds / 1000).ToString(format);
    }
}