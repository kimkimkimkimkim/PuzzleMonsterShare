using System;
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
}
