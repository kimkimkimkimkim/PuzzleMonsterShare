public class BattleConditionInfo
{
    /// <summary>
    /// Guid
    /// </summary>
    public string guid { get; set; }

    /// <summary>
    /// 付与者のバトルモンスターインデックス
    /// </summary>
    public BattleMonsterIndex grantorBattleMonsterIndex { get; set; }

    /// <summary>
    /// 状態異常ID
    /// </summary>
    public long battleConditionId { get; set; }

    /// <summary>
    /// 当該状態異常を付与したスキルのスキル効果
    /// </summary>
    public SkillEffectMI grantorSkillEffect { get; set; }

    /// <summary>
    /// アクション系状態異常のスキル効果
    /// BattleConditionMBのSkillEffect
    /// </summary>
    public BattleConditionSkillEfectMI battleConditionSkillEffect { get; set; }

    /// <summary>
    /// 残りターン数
    /// -1は永続
    /// </summary>
    public int remainingTurnNum { get; set; }

    /// <summary>
    /// アクション系の状態異常効果量
    /// </summary>
    public int actionValue { get; set; }

    /// <summary>
    /// シールド耐久値
    /// </summary>
    public int shieldValue { get; set; }

    /// <summary>
    /// 順序
    /// </summary>
    public int order { get; set; }
}