public class BattleConditionInfo
{
    /// <summary>
    /// 状態異常マスタ
    /// </summary>
    public BattleConditionMB battleCondition { get; set; }

    /// <summary>
    /// 状態異常効果
    /// </summary>
    public SkillEffectMI skillEffect { get; set; }

    /// <summary>
    /// 残りターン数
    /// -1は永続
    /// </summary>
    public int remainingTurnNum { get; set; }

    /// <summary>
    /// 付与時の状態異常効果量
    /// </summary>
    public int value { get; set; }

    /// <summary>
    /// シールド耐久値
    /// </summary>
    public int shieldValue { get; set; }
}
