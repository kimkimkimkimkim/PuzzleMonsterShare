using System.ComponentModel;
using PM.Enum.Battle;

/// <summary>
/// 状態異常マスタ
/// </summary>
[Description("BattleConditionMB")]
public class BattleConditionMB : MasterBookBase
{
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
    /// 状態異常効果発動タイミングタイプ
    /// </summary>
    public BattleConditionTriggerType battleConditionTriggerType { get; set; }

    /// <summary>
    /// 状態異常効果発動時に解除されるか否か
    /// </summary>
    public bool isRemovedWhenTriggered { get; set; }
}
