using System;

public static class DateTimeUtil
{
    /// <summary>
    /// 現在日時を返します
    /// TODO : 海外などの対応
    /// </summary>
    public static DateTime Now => DateTime.Now;

    /// <summary>
    /// 初期値を返します
    /// </summary>
    public static DateTime Epoch => DateTime.MinValue;
}