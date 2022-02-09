using PM.Enum.Condition;

/// <summary>
/// あらゆる条件を扱うクラス
/// </summary>
public class ConditionMI
{
    /// <summary>
    /// 条件タイプ
    /// </summary>
    public ConditionType type { get; set; }

    /// <summary>
    /// 値（整数）
    /// </summary>
    public int valueInt { get; set; }

    /// <summary>
    /// 値（文字列）
    /// </summary>
    public string valueString { get; set; }
}
