using System.ComponentModel;
using PM.Enum.Battle;

/// <summary>
/// 状態異常マスタ
/// </summary>
[Description("BattleConditionMB")]
public class BattleConditionMB : MasterBookBase
{
    /// <summary>
    /// 状態異常タイプ
    /// </summary>
    public BattleConditionType type { get; set; }
    
    /// <summary>
    /// 内容
    /// </summary>
    public string description { get; set; }
    
    /// <summary>
    /// 値
    /// </summary>
    public float value { get; set; }
}
