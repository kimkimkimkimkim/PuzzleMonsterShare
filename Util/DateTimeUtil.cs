using System;
using System.Linq;

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

    /// <summary>
    /// マスターでの日時文字列から日時情報を取得する
    /// （XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public static DateTime GetDateFromMasterString(string masterString)
    {
        try
        {
            var list = masterString.Split('-', ' ', ':').ToList();
            var year = int.Parse(list[0]);
            var month = int.Parse(list[1]);
            var day = int.Parse(list[2]);
            var hour = int.Parse(list[3]);
            var minute = int.Parse(list[4]);
            var second = int.Parse(list[5]);
            return new DateTime(year, month, day, hour, minute, second);
        }
        catch
        {
            return Epoch;
        }
    }
}