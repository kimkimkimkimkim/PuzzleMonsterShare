using System;
using System.Collections.Generic;
using System.Linq;
using PM.Enum.Item;

public static partial class ItemUtil
{
    /// <summary>
    /// ItemInstanceからItemMIを返す
    /// </summary>
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    public static ItemMI GetItemMI(PlayFab.ClientModels.ItemInstance itemInstance)
#else
    public static ItemMI GetItemMI(PlayFab.ServerModels.ItemInstance itemInstance)
#endif
    {
        return new ItemMI()
        {
            itemType = GetItemType(itemInstance),
            itemId = GetItemId(itemInstance),
            num = itemInstance.UsesIncrementedBy ?? 0,
        };
    }

    /// <summary>
    /// ItemInstanceからItemMIを返す
    /// </summary>
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    public static List<ItemMI> GetItemMIList(List<PlayFab.ClientModels.ItemInstance> itemInstanceList)
#else
    public static List<ItemMI> GetItemMIList(List<PlayFab.ServerModels.ItemInstance> itemInstanceList)
#endif
    {
        return itemInstanceList.Select(i => GetItemMI(i)).ToList();
    }

    /// <summary>
    /// 渡されたアイテムリストをすべて個数一つのアイテムに分解してリストで返す
    /// </summary>
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    public static List<ItemMI> GetSeparatedItemMIList(List<PlayFab.ClientModels.ItemInstance> itemInstanceList)
#else
    public static List<ItemMI> GetSeparatedItemMIList(List<PlayFab.ServerModels.ItemInstance> itemInstanceList)
#endif
    {
        var itemList = GetItemMIList(itemInstanceList);
        var separatedItemList = new List<ItemMI>();
        itemList.ForEach(item =>
        {
            var singleItem = new ItemMI()
            {
                itemType = item.itemType,
                itemId = item.itemId,
                num = 1,
            };
            for (var i = 0; i < item.num; i++)
            {
                separatedItemList.Add(singleItem);
            }
        });
        return separatedItemList;
    }

    /// <summary>
    /// ItemInstanceからIdを返す
    /// </summary>
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    public static long GetItemId(PlayFab.ClientModels.ItemInstance itemInstance)
#else
    public static long GetItemId(PlayFab.ServerModels.ItemInstance itemInstance)
#endif
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
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    public static ItemType GetItemType(PlayFab.ClientModels.ItemInstance itemInstance)
#else
    public static ItemType GetItemType(PlayFab.ServerModels.ItemInstance itemInstance)
#endif
    {
        // ItemInstanceのClassはItemTypeと等しい
        foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
        {
            if (itemInstance.ItemClass == itemType.ToString()) return itemType;
        }

        return ItemType.None;
    }
}
