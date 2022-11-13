using PM.Enum.Date;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// リワード広告マスタ
/// </summary>
[Description("RewardAdMB")]
public class RewardAdMB : MasterBookBase
{
    /// <summary>
    /// 説明文
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 期間タイプ
    /// </summary>
    public TermType termType { get; set; }
    
    /// <summary>
    /// 期間内の制限回数
    /// </summary>
    public int limitNum { get; set; }

    /// <summary>
    /// 確率付き報酬アイテムリスト
    /// </summary>
    public List<ProbabilityItemMI> itemList { get; set; }
}
