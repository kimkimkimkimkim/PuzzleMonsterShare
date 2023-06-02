using PM.Enum.Notification;
using System.Collections.Generic;

/// <summary>
/// ユーザーシステム通知情報
/// </summary>
public class UserNotificationInfo : UserDataBase {
    /// <summary>
    /// 通知タイプ
    /// </summary>
    public NotificationType notificationType { get; set; }

    /// <summary>
    /// 通知値
    /// </summary>
    public long notificationValue { get; set; }

    /// <summary>
    /// メッセージ(オプション)
    /// </summary>
    public string message { get; set; }

    /// <summary>
    /// お知らせID(オプション)
    /// </summary>
    public long newsId { get; set; }

    /// <summary>
    /// アイテムリスト(オプション)
    /// </summary>
    public List<ItemMI> itemList { get; set; }

    /// <summary>
    /// 同一の通知であるかを判定する。
    /// </summary>
    public bool IsSame(UserNotificationInfo userNotificationInfo) {
        return this.notificationType == userNotificationInfo.notificationType
            && this.notificationValue == userNotificationInfo.notificationValue
            && this.message == userNotificationInfo.message;
    }
}
