/// <summary>
/// レアリティ別の排出確率情報
/// </summary>
public class EmisionPercentByRarity {
    /// <summary>
    /// R全体の排出確率
    /// </summary>
    public float rAllPercent { get; set; }

    /// <summary>
    /// SR全体の排出確率
    /// </summary>
    public float srAllPercent { get; set; }

    /// <summary>
    /// SSR全体の排出確率
    /// </summary>
    public float ssrAllPercent { get; set; }

    /// <summary>
    /// ピックアップSSRモンスター1体の排出確率
    /// </summary>
    public float pickUpSsrPercent { get; set; }
}