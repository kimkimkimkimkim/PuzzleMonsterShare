using PM.Enum.Battle;

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
    /// スキル対象タイプ（共通）
    /// </summary>
    public SkillTargetType skillTargetType { get; set; }

    /// <summary>
    /// スキル対象に対する発動条件タイプ（共通）
    /// </summary>
    public ActivateConditionType activateConditionType { get; set; }

    /// <summary>
    /// 効果量の対象タイプ（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public ValueTargetType valueTargetType { get; set; }

    /// <summary>
    /// 効果量（%）（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public int value { get; set; }
    
    /// <summary>
    /// 効果量制限が存在するか否か（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public bool existsLimitValue { get; set; }
    
    /// <summary>
    /// 効果量の対象タイプ（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public ValueTargetType limitValueTargetType { get; set; }

    /// <summary>
    /// 効果量（%）（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public int limitValue { get; set; }
    
    /// <summary>
    /// スキル演出ID（攻撃、回復、アクション系以外の状態異常用）
    /// </summary>
    public long skillFxId { get; set; }

    /// <summary>
    /// 状態異常タイプ（状態異常用）
    /// </summary>
    public BattleConditionType battleConditionType { get; set; }

    /// <summary>
    /// 継続ターン数（状態異常用）
    /// </summary>
    public int durationTurnNum { get; set; }
    
    /// <summary>
    /// 解除可能か否か（状態異常用）
    /// </summary>
    public bool canUnlock { get; set; }
    
    /// <summary>
    /// 参照する状態異常効果リストの番号（アクション系の状態異常用）
    /// </summary>
    public int actionBattleConditionEffectListNumber { get; set; }
}
