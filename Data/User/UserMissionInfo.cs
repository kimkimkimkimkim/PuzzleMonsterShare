using System;

/// <summary>
/// ユーザーミッション情報
/// </summary>
public class UserMissionInfo : UserDataBase
{
    /// <summary>
    /// ミッションID
    /// </summary>
    public long missionId { get; set; }

    /// <summary>
    /// ミッションをクリアした日時
    /// </summary>
    public DateTime completedDate { get; set; }

    /// <summary>
    /// 有効期限開始日時
    /// </summary>
    public DateTime startExpirationDate { get; set; }

    /// <summary>
    /// 有効期限終了日時
    /// </summary>
    public DateTime endExpirationDate { get; set; }
}
