using System.Collections.Generic;
using System.ComponentModel;
using PM.Enum.Gacha;

[Description("GachaBoxDetailMB")]
public class GachaBoxDetailMB : MasterBookBase
{
    /// <summary>
    /// ガチャボックスID
    /// </summary>
    public long gachaBoxId { get; set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string title { get; set; }

    /// <summary>
    /// PlayFabで設定しているバンドルID
    /// </summary>
    public long bundleId { get; set; }

    /// <summary>
    /// 必要アイテムリスト
    /// </summary>
    public List<ItemMI> requiredItemList { get; set; }

    /// <summary>
    /// ガチャ実行タイプ
    /// </summary>
    public GachaExecuteType gachaExecuteType { get; set; }

    /// <summary>
    /// ガチャが表示されるのに必要な条件リスト
    /// </summary>
    public List<ConditionMI> displayConditionList { get; set; }

    /// <summary>
    /// ガチャを実行可能になる条件リスト
    /// </summary>
    public List<ConditionMI> canExecuteConditionList { get; set; }
}
