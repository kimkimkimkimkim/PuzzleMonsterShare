using System.ComponentModel;

/// <summary>
/// ガチャスケジュールマスタ
/// </summary>
[Description("GachaScheduleMB")]
public class GachaScheduleMB : MasterBookBase {
    /// <summary>
    /// 説明
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 対象のガチャBOXID
    /// </summary>
    public long gachaBoxId { get; set; }

    /// <summary>
    /// 開始日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string startDate { get; set; }

    /// <summary>
    /// 終了日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string endDate { get; set; }
}
