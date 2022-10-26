using System.ComponentModel;
using PM.Enum.Item;

/// <summary>
/// アイテム説明文マスタ
/// </summary>
[Description("ItemDescriptionMB")]
public class ItemDescriptionMB : MasterBookBase {
    /// <summary>
    /// アイテムタイプ
    /// </summary>
    public ItemType itemType { get; set; }

    /// <summary>
    /// アイテムID
    /// </summary>
    public long itemId { get; set; }

    /// <summary>
    /// アイテム名
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 説明文
    /// </summary>
    public string description { get; set; }
}
