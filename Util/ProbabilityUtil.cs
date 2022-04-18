using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 確率関係を扱うUtil
/// </summary>
public static class ProbabilityUtil
{
    /// <summary>
    /// 指定したアイテムリストの中から重みづけを元に1つアイテムを抽選し、当選したアイテムを返す
    /// </summary>
    public static ItemMI LotteryOneItemByWeight(List<ProbabilityItemMI> probabilityItemList) {
        ItemMI gotItem = null;

        var random = new System.Random(Guid.NewGuid().GetHashCode());
        var randomWeight = random.Next(0, probabilityItemList.Sum(p => p.weight));

        foreach (var probabilityItem in probabilityItemList) {
            randomWeight -= probabilityItem.weight;
            if (randomWeight >= 0) continue;

            gotItem = probabilityItem;
            break;
        }

        return gotItem;
    }

    /// <summary>
    /// 指定したアイテムリストの中の全アイテムに対しパーセントを元に抽選を行い、当選したすべてのアイテムをリストで返す
    /// </summary>
    public static List<ItemMI> LotteryAllItemByPercent(List<ProbabilityItemMI> probabilityItemList) {
        return probabilityItemList.Where(probabilityItem => {
            var random = new System.Random(Guid.NewGuid().GetHashCode());
            var randomPercent = random.NextDouble() * 100.0f;
            return randomPercent <= probabilityItem.percent;
        }).Select(probabilityItem => (ItemMI)probabilityItem).ToList();
    }
}
