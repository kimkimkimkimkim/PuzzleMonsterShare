/// <summary>
/// 確率付きアイテム情報
/// </summary>
public class ProbabilityItemMI : ItemMI
{
    /// <summary>
    /// 確率(%)
    /// 0 ~ 100
    /// </summary>
    public double percent { get; set; }
    
    /// <summary>
    /// 重み
    /// 主にガチャ用
    /// </summary>
    public int weight { get; set; }
}
