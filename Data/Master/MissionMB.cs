using PM.Enum.Mission;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// ミッションマスタ
/// </summary>
[Description("MissionMB")]
public class MissionMB : MasterBookBase
{
    /// <summary>
    /// ミッションタイプ
    /// </summary>
    public MissionType missionType { get; set; }

    /// <summary>
    /// ミッション名
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// ミッション説明
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 報酬アイテムリスト
    /// </summary>
    public List<ItemMI> rewardItemList { get; set; }

    /// <summary>
    /// ミッションが表示されるのに必要な条件リスト
    /// </summary>
    public List<ConditionMI> displayConditionList { get; set; }

    /// <summary>
    /// ミッションクリアになる条件リスト
    /// </summary>
    public List<ConditionMI> canClearConditionList { get; set; }
}
