using System;

/// <summary>
/// ユーザープレゼント情報
/// </summary>
public class UserPresentInfo : UserDataBase
{
    /// <summary>
    /// アイテム内容
    /// </summary>
    public ItemMI item { get; set; }

    /// <summary>
    /// 付与された日時
    /// </summary>
    public DateTime grantedDate { get; set; }

    /// <summary>
    /// プレゼントを受け取った日時
    /// </summary>
    public DateTime receivedDate { get; set; }
}
