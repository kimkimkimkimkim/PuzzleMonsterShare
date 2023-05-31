using System.ComponentModel;
using System.Collections.Generic;
using PM.Enum.News;
using System;
using PM.Enum.Notification;

[Description("NewsMB")]
public class NewsMB : MasterBookBase
{
    /// <summary>
    /// タイプ
    /// </summary>
    public NewsType type { get; set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string title { get; set; }

    /// <summary>
    /// 開始日時
    /// </summary>
    public DateTime startDate { get; set; }

    /// <summary>
    /// 終了日時
    /// </summary>
    public DateTime endDate { get; set; }

    /// <summary>
    /// 繰り返しタイプ
    /// </summary>
    public RepeatType repeatType { get; set; }

    /// <summary>
    /// メッセージ
    /// </summary>
    public string message { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<ItemMI> itemList { get; set; }
}