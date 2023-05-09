/// <summary>
/// バトル用のスキル効果を扱うためのクラス
/// </summary>
public class BattleSkillEffectMI
{
    /// <summary>
    /// 発動するか否か
    /// </summary>
    public bool isActive { get; set; }

    /// <summary>
    /// スキル効果
    /// </summary>
    public SkillEffectMI skillEffect { get; set; }
}