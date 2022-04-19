using System;

/// <summary>
/// ユーザープレゼント情報
/// </summary>
public class UserPresentInfo : UserDataBase
{
    /// <summary>
    /// タイトル
    /// </summary>
    public string title { get; set; }

    /// <summary>
    /// 本文
    /// </summary>
    public string message { get; set; }

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

    /// <summary>
    /// 受け取り期限日時
    /// </summary>
    public DateTime deadlineDate { get; set; }

    /// <summary>
    /// 受け取り可能なプレゼントか否か
    /// </summary>
    public bool IsValid()
    {
        return receivedDate <= DateTimeUtil.Epoch && (deadlineDate <= DateTimeUtil.Epoch || deadlineDate > DateTimeUtil.Now);
    }
}
