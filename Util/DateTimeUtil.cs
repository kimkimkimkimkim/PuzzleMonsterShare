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

    /// <summary>
    /// 指定した日時がゲーム内の今日かどうかを判定する
    /// </summary>
    public static bool IsToday(DateTime date)
    {
        // 現在時刻とゲーム内の今日が同じ日にちか否か
        var isSameDate = Now.Hour >= ConstManager.System.START_DAY_HOUR;

        // 現在時刻とゲーム内の今日が同じ日にちなら基準日は現在時刻、違うなら基準日は現在時刻の一日前
        var baseDate = isSameDate ? Now : Now.AddDays(-1);

        var startDate = new DateTime(baseDate.Year, baseDate.Month, baseDate.Day, ConstManager.System.START_DAY_HOUR, 0, 0);
        var endDate = startDate;
        endDate.AddDays(1);

        return startDate <= date && date < endDate;
    }
}