using System.Collections.Generic;
using System.ComponentModel;
using PM.Enum.Battle;

/// <summary>
/// アクティブスキルマスタ
/// </summary>
[Description("ActiveSkillMB")]
public class ActiveSkillMB : MasterBookBase
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
    public List<SkillEffectMI> skillEffectList { get; set; }
}
