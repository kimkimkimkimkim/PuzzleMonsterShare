using PM.Enum.Condition;

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
                // 指定クエストをクリアしているか
                case ConditionType.UpperQuestId:
                    return userData.userBattleList.Any(u => u.questId == condition.intValue && u.completedTime <= DateTimeUtil.Epoch);
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
