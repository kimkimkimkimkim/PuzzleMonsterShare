using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// ロッカブルマスタ
/// </summary>
[Description("LockableMB")]
public class LockableMB : MasterBookBase {
    /// <summary>
    /// 説明
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// コンディションリスト
    /// このコンディションを満たしていればロックされる
    /// </summary>
    public List<ConditionMI> lockConditionList { get; set; }
}
