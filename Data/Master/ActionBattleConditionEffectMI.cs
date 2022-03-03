using PM.Enum.Battle;

/// <summary>
/// アクション系の状態異常効果を扱うためのクラス
/// </summary>
public class ActionBattleConditionEffectMI: SkillEffectMI
{
    /// <summary>
    /// スキルトリガータイプ
    /// </summary>
    public SkillTriggerType triggerType { get; set; }
}
