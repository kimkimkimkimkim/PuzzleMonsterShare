using System;

/// <summary>
/// 確率関係を扱うUtil
/// </summary>
public static class ProbabilityUtil
{
    /// <summary>
    /// 指定した確率で当選したか否かを返す
    /// </summary>
    /// <param name="percent">0～100</param>
    public static bool DetectByPercent(double percent)
    {
        var random = new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 100;
        return percent <= random;
    }
}
