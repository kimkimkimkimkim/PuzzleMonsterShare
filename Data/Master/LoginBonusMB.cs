using System.Collections.Generic;
using System.ComponentModel;

[Description("LoginBonusMB")]
public class LoginBonusMB : MasterBookBase
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
    /// 付与するコンテナID
    /// </summary>
    public long containerId { get; set; }

    /// <summary>
    /// 付与条件リスト
    /// </summary>
    public List<ConditionMI> conditionList { get; set; }

    /// <summary>
    /// 条件を満たしていれば何度でも付与するか否か
    /// </summary>
    public bool isContinue { get; set; }
}
