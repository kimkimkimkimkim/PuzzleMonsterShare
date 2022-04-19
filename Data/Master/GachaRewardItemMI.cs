/// <summary>
/// ガチャ報酬アイテム情報
/// </summary>
public class GachaRewardItemMI : ItemMI
{   
    /// <summary>
    /// 確定枠か否か
    /// </summary>
    public bool isConfirmed { get; set; }

    public GachaRewardItemMI(ItemMI item)
    {
        itemType = item.itemType;
        itemId = item.itemId;
        num = item.num;
    }
}
