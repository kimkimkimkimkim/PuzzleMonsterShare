using System.ComponentModel;

/// <summary>
/// メンテナンスマスタ
/// </summary>
[Description("MaintenanceMB")]
public class MaintenanceMB : MasterBookBase
{
    /// <summary>
    /// 開始日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string startDate { get; set; }

    /// <summary>
    /// 終了日時（XXXX-XX-XX XX:XX:XX）
    /// </summary>
    public string endDate { get; set; }

    /// <summary>
    /// 本文
    /// nullなら定型文
    /// </summary>
    public string text { get; set; }
}