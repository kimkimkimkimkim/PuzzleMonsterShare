using System.ComponentModel;
using System.Collections.Generic;
using PM.Enum.News;

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
    /// メッセージ
    /// </summary>
    public string message { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<ItemMI> itemList { get; set; }
}