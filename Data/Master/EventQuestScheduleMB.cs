using System.ComponentModel;

/// <summary>
/// イベントクエストスケジュールマスタ
/// </summary>
[Description("EventQuestScheduleMB")]
public class EventQuestScheduleMB : MasterBookBase
{
    /// <summary>
    /// 説明
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 対象のクエストカテゴリID
    /// </summary>
    public long questCategoryId { get; set; }

    /// <summary>
    /// 開始日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string startDate { get; set; }

    /// <summary>
    /// 終了日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string endDate { get; set; }
}
