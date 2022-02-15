using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// コンテナマスタ
/// </summary>
[Description("BundleMB")]
public class ContainerMB : MasterBookBase
{
    /// <summary>
    /// クエストカテゴリ名
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// アイテムリスト
    /// </summary>
    public List<ItemMI> itemList { get; set; }
}
