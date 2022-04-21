using System;
using System.Linq;
using PM.Enum.Mission;

public static class DateTimeUtil
{
    private static readonly TimeZoneInfo TIMEZONE_JST = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");

    /// <summary>
    /// 現在日時を返します
    /// 常に日本時間を返す
    /// </summary>
    public static DateTime Now => TimeZoneInfo.ConvertTime(DateTimeOffset.Now, TIMEZONE_JST).DateTime;

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
    /// 指定した日時のゲーム内当日開始日時を返す
    /// 例) 4/12 12:22 → 4/12 04:00
    /// </summary>
    public static DateTime GetStartDate(DateTime date){
        var startAndEndDate = GetStartAndEndDate(MissionType.Daily);
        return startAndEndDate.startDate;
    }

    /// <summary>
    /// 指定した日時がゲーム内の今日かどうかを判定する
    /// </summary>
    public static bool IsToday(DateTime date)
    {
        var startAndEndDate = GetStartAndEndDate(MissionType.Daily);

        // 終了日時は開始日時と被らないようになっているのでどちらもイコールをつける
        return startAndEndDate.startDate <= date && date <= startAndEndDate.endDate;
    }

    /// <summary>
    /// 指定した2つの日時の日付が等しいか否か
    /// </summary>
    public static bool IsSameDate(DateTime dateA, DateTime dateB){
        return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
    }

    /// <summary>
    /// 指定した2つの日時がゲーム内日時として等しいか否か
    /// </summary>
    public static bool IsSameGameDate(DateTime dateA, DateTime dateB)
    {
        var startAndEndDate = GetStartAndEndDate(MissionType.Daily, dateA);

        // 終了日時は開始日時と被らないようになっているのでどちらもイコールをつける
        return startAndEndDate.startDate <= dateB && dateB <= startAndEndDate.endDate;
    }

    /// <summary>
    /// 指定したミッションタイプに応じた開始日時、終了日時を返す
    /// </summary>
    public static (DateTime startDate, DateTime endDate) GetStartAndEndDate(MissionType missionType){
        return GetStartAndEndDate(missionType, Now);
    }

    public static (DateTime startDate, DateTime endDate) GetStartAndEndDate(MissionType missionType, DateTime date)
    {
        switch (missionType)
        {
            case MissionType.Daily:
                var endDayHour = ConstManager.System.START_DAY_HOUR - 1;
                if (endDayHour < 0) endDayHour += 24;

                // 現在時刻とゲーム内の今日が同じ日にちか否か
                var isSameDate = date.Hour >= ConstManager.System.START_DAY_HOUR;

                // 現在時刻とゲーム内の今日が同じ日にちなら基準日は現在時刻、違うなら基準日は現在時刻の一日前
                var baseDate = isSameDate ? date : date.AddDays(-1);

                var startDate = new DateTime(baseDate.Year, baseDate.Month, baseDate.Day, ConstManager.System.START_DAY_HOUR, 0, 0);
                var endDate = startDate.AddDays(1);
                endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDayHour, 59, 59, 999);

                return (startDate, endDate);
            // Weekly, Monthlyの実装
            case MissionType.Weekly:
            case MissionType.Monthly:
            case MissionType.Main:
            case MissionType.Event:
            default:
                return (Epoch, Epoch);
        }
    }
}