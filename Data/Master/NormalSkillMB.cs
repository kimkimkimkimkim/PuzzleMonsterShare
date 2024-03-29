﻿using PM.Enum.Battle;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// 通常スキルマスタ
/// </summary>
[Description("NormalSkillMB")]
public class NormalSkillMB : MasterBookBase
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
    /// スキル効果リスト
    /// </summary>
    public List<NormalSkillEffectMI> effectList { get; set; }
}
