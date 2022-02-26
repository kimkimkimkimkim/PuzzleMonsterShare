using PM.Enum.Battle;

/// <summary>
/// スキル効果を扱うためのクラス
/// </summary>
public class SkillEffectMI
{
    /// <summary>
    /// スキル対象タイプ
    /// </summary>
    public SkillTargetType skillTargetType { get; set; }

    /// <summary>
    /// スキル対象に対する発動条件タイプ
    /// </summary>
    public ActivateConditionType activateConditionType { get; set; }

    /// <summary>
    /// 効果量の対象タイプ
    /// </summary>
    public ValueTargetType valueTargetType { get; set; }

    /// <summary>
    /// スキルタイプ
    /// </summary>
    public SkillType type { get; set; }

    /// <summary>
    /// 効果量（%）
    /// </summary>
    public int value { get; set; }

    /// <summary>
    /// 状態異常タイプ（状態異常用）
    /// </summary>
    public BattleConditionType battleConditionType { get; set; }

    /// <summary>
    /// 継続ターン数（状態異常用）
    /// </summary>
    public int durationTurnNum { get; set; }

    /// <summary>
    /// スキル演出ID
    /// </summary>
    public long skillFxId { get; set; }
}
