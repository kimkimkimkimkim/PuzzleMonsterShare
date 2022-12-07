using PM.Enum.Battle;
using System.Collections.Generic;

/// <summary>
/// スキル効果を扱うためのクラス
/// </summary>
public class SkillEffectMI
{
    /// <summary>
    /// スキルタイプ（共通）
    /// </summary>
    public SkillType type { get; set; }

    /// <summary>
    /// スキル実行者に対する発動条件タイプ（共通）
    /// </summary>
    public ActivateConditionType doMonsterActivateConditionType { get; set; }

    /// <summary>
    /// スキル対象に対する発動条件タイプ（共通）
    /// </summary>
    public ActivateConditionType activateConditionType { get; set; }

    /// <summary>
    /// 発動確率（%）（共通）
    /// 0の場合は直前の要素が発動したら発動
    /// </summary>
    public int activateProbability { get; set; }

    /// <summary>
    /// スキル対象タイプ（共通）
    /// </summary>
    public SkillTargetType skillTargetType { get; set; }

    /// <summary>
    /// 効果量の対象タイプ（共通）
    /// </summary>
    public ValueTargetType valueTargetType { get; set; }

    /// <summary>
    /// 効果量（%）（共通）
    /// </summary>
    public int value { get; set; }

    /// <summary>
    /// 効果量制限が存在するか否か（共通）
    /// </summary>
    public bool existsLimitValue { get; set; }

    /// <summary>
    /// 効果量の対象タイプ（共通）
    /// </summary>
    public ValueTargetType limitValueTargetType { get; set; }

    /// <summary>
    /// 効果量（%）（共通）
    /// </summary>
    public int limitValue { get; set; }

    /// <summary>
    /// スキル演出ID（共通）
    /// </summary>
    public long skillFxId { get; set; }
    
    /// <summary>
    /// 状態異常ID（状態異常用）
    /// </summary>
    public long battleConditionId { get; set; }

    /// <summary>
    /// 継続ターン数（状態異常用）
    /// </summary>
    public int durationTurnNum { get; set; }

    /// <summary>
    /// 解除する状態異常IDリスト
    /// </summary>
    public List<long> removeBattleConditionIdList { get; set; }

    /// <summary>
    /// 解除する状態異常の個数
    /// 0: すべて
    /// </summary>
    public int removeBattleConsitionNum { get; set; }
    
    /// <summary>
    /// 解除可能か否か（状態異常用）
    /// </summary>
    public bool canRemove { get; set; }
}
