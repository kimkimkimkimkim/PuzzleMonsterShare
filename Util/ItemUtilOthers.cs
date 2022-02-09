﻿using System;
using System.Collections.Generic;
using System.Linq;
using PM.Enum.Item;
using PM.Enum.Monster;
using PM.Enum.UI;

public static partial class ItemUtil
{
    /// <summary>
    /// モンスターマスタからユーザーモンスターデータを作成する
    /// </summary>
    public static List<UserMonsterInfo> GetUserMonsterList(List<MonsterMB> monsterList)
    {
        return monsterList.Select(m => GetUserMonster(m)).ToList();
    }

    /// <summary>
    /// モンスターマスタからユーザーモンスターデータを作成する
    /// </summary>
    public static UserMonsterInfo GetUserMonster(MonsterMB monster)
    {
        return new UserMonsterInfo()
        {
            id = UserDataUtil.CreateUserDataId(),
            monsterId = monster.id,
            customData = new UserMonsterCustomData()
            {
                grade = monster.initialGrade,
            }
        };
    }

    /// <summary>
    /// ItemInstanceからItemMIを返す
    /// </summary>
    public static ItemMI GetItemMI(UserMonsterInfo userMonster)
    {
        return new ItemMI()
        {
            itemType = ItemType.Monster,
            itemId = userMonster.monsterId,
            num = 1,
        };
    }

    /// <summary>
    /// PlayFabのアイテムIDを返す
    /// </summary>
    public static string GetItemId(ItemType type, long id)
    {
        return $"{type}{id}";
    }

    /// <summary>
    /// アイコン画像タイプを取得する
    /// </summary>
    public static IconImageType GetIconImageType(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Monster:
                return IconImageType.Monster;
            case ItemType.Property:
                return IconImageType.Property;
            case ItemType.VirtualCurrency:
                return IconImageType.VirtualCurrency;
            default:
                return IconImageType.None;
        }
    }

    /// <summary>
    /// アイコン色タイプを取得する
    /// </summary>
    public static IconColorType GetIconColorType(ItemMI item)
    {
        switch (item.itemType)
        {
            case ItemType.Monster:
                var monster = MasterRecord.GetMasterOf<MonsterMB>().Get(item.itemId);
                var iconColorType = ItemUtil.GetIconColorType(monster.attribute);
                return iconColorType;
            default:
                return IconColorType.None;
        }
    }

    /// <summary>
    /// アイコン色タイプを取得する
    /// </summary>
    public static IconColorType GetIconColorType(MonsterAttribute monsterAttribute)
    {
        switch (monsterAttribute)
        {
            case MonsterAttribute.Red:
                return IconColorType.Red;
            case MonsterAttribute.Blue:
                return IconColorType.Blue;
            case MonsterAttribute.Green:
                return IconColorType.Green;
            case MonsterAttribute.Yellow:
                return IconColorType.Yellow;
            case MonsterAttribute.Purple:
                return IconColorType.Purple;
            default:
                return IconColorType.None;
        }
    }
}
