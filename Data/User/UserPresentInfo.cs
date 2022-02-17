using System;

/// <summary>
/// ユーザープレゼント情報
/// </summary>
public class UserPresentInfo : UserDataBase
{
    /// <summary>
    /// コンテナID
    /// </summary>
    public long containerId { get; set; }

    /// <summary>
    /// コンテナが付与された日時
    /// </summary>
    public DateTime grantedDate { get; set; }

    /// <summary>
    /// コンテナを開けた日時
    /// </summary>
    public DateTime unlockedDate { get; set; }
}
