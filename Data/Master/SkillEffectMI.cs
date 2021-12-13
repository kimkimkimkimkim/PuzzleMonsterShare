using PM.Enum.Battle;
/// <summary>
/// スキル効果を扱うためのクラス
/// </summary>
public class SkillEffectMI
{
    /// <summary>
    /// スキル対象タイプ
    /// </summary>
    public SkillTargetType targetType { get; set; }

    /// <summary>
    /// スキルタイプ
    /// </summary>
    public SkillType type { get; set; }

    /// <summary>
    /// 効果量
    /// </summary>
    public float value { get; set; }
}
