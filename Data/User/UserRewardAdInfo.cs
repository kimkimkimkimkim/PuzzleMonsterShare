using System;

/// <summary>
/// ユーザーリワード広告情報
/// </summary>
public class UserRewardAdInfo : UserDataBase
{
    /// <summary>
    /// リワード広告ID
    /// </summary>
    public long rewardAdId { get; set; }

    /// <summary>
    /// 当選したインデックス
    /// </summary>
    public int electedIndex { get; set; }

    /// <summary>
    /// 付与された日時
    /// </summary>
    public DateTime grantedDate { get; set; }
}
