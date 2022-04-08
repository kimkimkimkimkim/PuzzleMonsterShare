using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// クエストマスタ
/// </summary>
[Description("QuestMB")]
public class QuestMB : MasterBookBase
{
    /// <summary>
    /// クエスト名
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// クエストカテゴリID
    /// </summary>
    public long questCategoryId { get; set; }

    /// <summary>
    /// 初回報酬アイテムリスト
    /// </summary>
    public List<ItemMI> firstRewardItemList { get; set; }

    /// <summary>
    /// ドロップアイテムリスト
    /// </summary>
    public List<ProbabilityItemMI> dropItemList { get; set; }

    /// <summary>
    /// ウェーブ毎のクエストモンスターリスト
    /// </summary>
    public List<List<QuestMonsterMI>> questMonsterListByWave { get; set; }

    /// <summary>
    /// クエストが表示されるのに必要な条件リスト
    /// </summary>
    public List<ConditionMI> displayConditionList { get; set; }

    /// <summary>
    /// クエストに挑戦可能になる条件リスト
    /// </summary>
    public List<ConditionMI> canExecuteConditionList { get; set; }

    /// <summary>
    /// 消費するスタミナ量
    /// </summary>
    public int consumeStamina { get; set; }
    
    /// <summary>
    /// 上限ターン数
    /// </summary>
    public int limitTurnNum { get; set; }
}
