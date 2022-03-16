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
    /// トリガータイプ用のオプション値
    /// 状態異常付与トリガーの状態異常IDなど
    /// </summary>
    public int triggerTypeOptionValue { get; set; }
}
