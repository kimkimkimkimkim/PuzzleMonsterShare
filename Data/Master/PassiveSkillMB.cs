using PM.Enum.Battle;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// パッシブスキルマスタ
/// </summary>
[Description("PassiveSkillMB")]
public class PassiveSkillMB : MasterBookBase
{
    /// <summary>
    /// 名前
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 説明
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// スキル実行者に対する発動条件タイプ
    /// </summary>
    public ActivateConditionType activateConditionType { get; set; }
    
    /// <summary>
    /// バトル内での発動制限回数
    /// 0 は制限なし
    /// </summary>
    public int limitExecuteNum { get; set; }

    /// <summary>
    /// パッシブスキル効果リスト
    /// </summary>
    public List<PassiveSkillEffectMI> effectList { get; set; }
}
