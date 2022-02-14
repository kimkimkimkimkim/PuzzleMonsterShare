using PM.Enum.Condition;
using System.Collections.Generic;
using System.Linq;
using PM.Enum.Battle;

public static class ConditionUtil {
    /// <summary>
    /// 指定した条件リストを満たしていればtrueを、満たしていなければfalseを返します
    /// </summary>
    public static bool IsValid(UserDataInfo userData, List<ConditionMI> conditionList) {
        // 何も条件が無い場合は条件を満たしていると判定
        if (!conditionList.Any()) return true;
        
        // すべての条件を満たしていればtrueを返す
        return conditionList.All(condition => {
            switch(condition.type) {
                case ConditionType.UpperQuestId:
                    // 指定クエスト以上進んでいるか
                    return userData.userBattleList.Any(u => u.questId == condition.valueInt && u.winOrLose == WinOrLose.Win && u.completedDate > DateTimeUtil.Epoch);
                case ConditionType.LowerQuestId:
                    return true;
                case ConditionType.UpperDate:
                    // 指定日時以降か
                    return DateTimeUtil.GetDateFromMasterString(condition.valueString) <= DateTimeUtil.Now;
                case ConditionType.LowerDate:
                    // 指定日時以前か
                    return DateTimeUtil.Now < DateTimeUtil.GetDateFromMasterString(condition.valueString);
                case ConditionType.UpperMissionId:
                    // 指定ミッションをクリアしているか
                    return userData.userMissionList.Any(u => u.missionId == condition.valueInt && u.completedDate > DateTimeUtil.Epoch && u.startExpirationDate <= DateTimeUtil.Now && DateTimeUtil.Now < u.endExpirationDate);
                case ConditionType.LowerMissionId:
                    return true;
                case ConditionType.UpperPlayerRank:
                    // 指定プレイヤーランク以上か
                    return userData.rank >= condition.valueInt;
                case ConditionType.LowerPlayerRank:
                    // 指定プレイヤーランク以下か
                    return userData.rank <= condition.valueInt;
                case ConditionType.AllClearDailyMission:
                    // 今日のデイリーミッションをすべてクリアしているか
                    // TODO: もっといい判定
                    var dailyMissionIdList = new List<long>() { 200010001, 200010002 };
                    var validMissionList = userData.userMissionList.Where(u => u.completedDate > DateTimeUtil.Epoch)
                        .Where(u => (u.startExpirationDate <= DateTimeUtil.Epoch && u.endExpirationDate <= DateTimeUtil.Epoch) || (u.startExpirationDate > DateTimeUtil.Epoch && u.endExpirationDate > DateTimeUtil.Epoch && u.startExpirationDate <= DateTimeUtil.Now && DateTimeUtil.Now < u.endExpirationDate))
                        .ToList();
                    return dailyMissionIdList.All(id => validMissionList.Any(u => u.missionId == id));
                case ConditionType.UpperTotalLoginDate:
                    // 通算ログイン日数が指定日数以上か
                    return true;
                case ConditionType.LowerTotalLoginDate:
                    // 通算ログイン日数が指定日数以下か
                    return true;
                case ConditionType.LoginToday:
                    // 今日ログインしたか
                    return true;
                case ConditionType.ClearQuestToday:
                    // 今日クエストをクリアしたか
                    return userData.userBattleList.Any(u => u.winOrLose == WinOrLose.Win && DateTimeUtil.IsToday(u.completedDate));
                default:
                    return true;
            }
        });
    }
    
    public static bool IsValid(UserDataInfo userData, ConditionMI condition) {
        var conditionList = new List<ConditionMI>(){ condition };
        return IsValid(userData, conditionList);
    }
}
