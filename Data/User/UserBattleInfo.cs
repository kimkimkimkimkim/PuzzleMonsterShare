using System;
using System.Collections.Generic;
using PM.Enum.Battle;

/// <summary>
/// ユーザーバトル情報
/// </summary>
public class UserBattleInfo: UserDataBase
{
    /// <summary>
    /// クエストID
    /// </summary>
    public long questId { get; set; }

    /// <summary>
    /// ユーザーパーティID
    /// </summary>
    public string userMonsterPartyId { get; set; }

    /// <summary>
    /// バトルログリスト
    /// </summary>
    public List<BattleLogInfo> battleLogList { get; set; }

    /// <summary>
    /// 勝敗
    /// </summary>
    public WinOrLose winOrLose { get; set; }

    /// <summary>
    /// 初回クリア報酬アイテムリスト（受け取るまでは空）
    /// </summary>
    public List<ItemMI> firstClearRewardItemList { get; set; }

    /// <summary>
    /// 報酬アイテムリスト（受け取るまでは空）
    /// </summary>
    public List<ItemMI> rewardItemList { get; set; }

    /// <summary>
    /// バトルが終わり報酬までもらいきった時間
    /// </summary>
    public DateTime completedDate { get; set; }
}
