using System.ComponentModel;
using System.Collections.Generic;
using PM.Enum.News;
using PM.Enum.Notification;

[Description("NewsMB")]
public class NewsMB : MasterBookBase {
    /// <summary>
    /// タイプ
    /// </summary>
    public NewsType type { get; set; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string title { get; set; }

    /// <summary>
    /// 条件リスト
    /// 条件を満たすときだけ処理実行
    /// </summary>
    public List<ConditionMI> conditionList { get; set; }

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
