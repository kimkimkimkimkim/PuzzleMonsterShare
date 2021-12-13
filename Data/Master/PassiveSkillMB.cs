using System.Collections.Generic;
using System.ComponentModel;
using PM.Enum.Battle;

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
    /// パッシブスキル効果リスト
    /// </summary>
    public List<PassiveSkillEffectMI> passiveSkillEffectList { get; set; }
}
