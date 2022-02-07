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
