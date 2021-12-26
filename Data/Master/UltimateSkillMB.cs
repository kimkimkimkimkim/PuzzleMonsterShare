using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// アルティメットスキルマスタ
/// </summary>
[Description("UltimateSkillMB")]
public class UltimateSkillMB : MasterBookBase
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
    /// スキル効果リスト
    /// </summary>
    public List<UltimateSkillEffectMI> skillEffectList { get; set; }
}
