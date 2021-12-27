using PM.Enum.Battle;

/// <summary>
/// パッシブスキル効果を扱うためのクラス
/// </summary>
public class PassiveSkillEffectMI: SkillEffectMI
{
    /// <summary>
    /// スキルトリガータイプ
    /// </summary>
    public SkillTriggerType triggerType { get; set; }

    /// <summary>
    /// 発動条件タイプ
    /// </summary>
    public ActivateConditionType activateConditionType { get; set; }
}
