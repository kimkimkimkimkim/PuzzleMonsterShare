/// <summary>
/// ユーザーのモンスター情報
/// </summary>
public class UserMonsterInfo: InventoryDataBase
{
    /// <summary>
    /// モンスターID
    /// </summary>
    public long monsterId { get; set; }

    /// <summary>
    /// 数
    /// </summary>
    public int num { get; set; }

    /// <summary>
    /// カスタムデータ
    /// </summary>
    public UserMonsterCustomData customData { get; set; }
}
