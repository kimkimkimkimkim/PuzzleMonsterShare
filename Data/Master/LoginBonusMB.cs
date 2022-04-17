using PM.Enum.LoginBonus;
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
    /// 繰り返しタイプ
    /// </summary>
    public RepeatType repeatType { get; set; }

    /// <summary>
    /// 繰り返し値
    /// </summary>
    public int repeatValue { get; set; }

    /// <summary>
    /// 付与条件リスト
    /// </summary>
    public List<ConditionMI> conditionList { get; set; }

    /// <summary>
    /// 報酬アイテムリスト
    /// 1日ずつの報酬が各要素に格納されている
    /// </summary>
    public List<ItemMI> rewardItemList { get; set; }
}
