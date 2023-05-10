using System.ComponentModel;
using PM.Enum.Battle;
using PM.Enum.Monster;

/// <summary>
/// 状態異常マスタ
/// </summary>
[Description("BattleConditionMB")]
public class BattleConditionMB : MasterBookBase
{
    /// <summary>
    /// 名前
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 状態異常タイプ
    /// </summary>
    public BattleConditionType battleConditionType { get; set; }

    /// <summary>
    /// バフタイプ
    /// </summary>
    public BuffType buffType { get; set; }

    /// <summary>
    /// 状態異常効果発動時に解除されるか否か
    /// </summary>
    public bool isRemovedWhenTriggered { get; set; }

    /// <summary>
    /// 対象のバトルモンスターステータスタイプ（ステータス上昇系など用）
    /// </summary>
    public BattleMonsterStatusType targetBattleMonsterStatusType { get; set; }

    /// <summary>
    /// 対象の状態異常ID（状態異常特攻用）
    /// </summary>
    public long targetBattleConditionId { get; set; }

    /// <summary>
    /// 対象のバフタイプ（特定バフタイプの個数特攻用）
    /// </summary>
    public BuffType targetBuffType { get; set; }

    /// <summary>
    /// 対象の属性（属性特攻用）
    /// </summary>
    public MonsterAttribute targetMonsterAttribute { get; set; }

    /// <summary>
    /// 効果量タイプ（アクション用）
    /// </summary>
    public BattleConditionActionValueType actionValueType { get; set; }

    /// <summary>
    /// スキル効果（アクション用）
    /// </summary>
    public BattleConditionSkillEfectMI skillEffect { get; set; }
}