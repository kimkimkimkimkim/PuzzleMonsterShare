#if !UNITY_EDITOR && !UNITY_IOS && !UNITY_ANDROID && !UNITY_STANDALONE_OSX && !UNITY_STANDALONE_WIN
using System;
using PlayFab.ServerModels;
using PM.Enum.Item;
using System.Collections.Generic;

public static partial class ItemUtil
{
    /// <summary>
    /// ItemInstanceからIdを返す
    /// </summary>
    public static long GetItemId(GrantedItemInstance itemInstance)
    {
        // ItemInstanceのIdは「ItemType名+ID値」となっている
        var itemTypeWordCount = itemInstance.ItemClass.Length;
        var itemInstanceId = itemInstance.ItemId;
        var id = itemInstanceId.Substring(itemTypeWordCount);
        return long.Parse(id);
    }

    /// <summary>
    /// ItemInstanceからItemTypeを返す
    /// </summary>
    public static ItemType GetItemType(GrantedItemInstance itemInstance)
    {
        // ItemInstanceのClassはItemTypeと等しい
        foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
        {
            if (itemInstance.ItemClass == itemType.ToString()) return itemType;
        }

        return ItemType.None;
    }

    /// <summary>
    /// GrantedItemInstanceからItemMIを返す
    /// </summary>
    public static ItemMI GetItemMI(GrantedItemInstance itemInstance)
    {
        return new ItemMI()
        {
            itemType = GetItemType(itemInstance),
            itemId = GetItemId(itemInstance),
            num = itemInstance.UsesIncrementedBy ?? 0,
        };
    }

    /// <summary>
    /// 仮想通貨個数情報からItemMIを返す
    /// </summary>
    public static GrantedItemInstance GetGrantedItemInstance(VirtualCurrencyNumInfo virtualCurrencyNum){
        return new GrantedItemInstance()
        {
            ItemClass = "VirtualCurrency",
            ItemId = $"VirtualCurrency{virtualCurrencyNum.virtualCurrencyId}",
            UsesIncrementedBy = virtualCurrencyNum.num,
        };
    }
}
#endif