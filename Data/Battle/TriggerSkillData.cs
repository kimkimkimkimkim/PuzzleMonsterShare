using PM.Enum.Battle;

/// <summary>
/// トリガースキル情報
/// </summary>
public class TriggerSkillData
{
    /// <summary>
    /// バトルモンスターインデックス
    /// </summary>
    public BattleMonsterIndex battleMonsterIndex { get; set; }

    /// <summary>
    /// バトルアクションタイプ
    /// </summary>
    public BattleActionType battleActionType { get; set; }

    /// <summary>
    /// スキルGuid
    /// </summary>
    public string skillGuid { get; set; }

    /// <summary>
    /// スキル効果インデックス
    /// </summary>
    public int skillEffectIndex { get; set; }
}