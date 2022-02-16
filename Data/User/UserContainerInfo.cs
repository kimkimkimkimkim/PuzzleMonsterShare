/// <summary>
/// ユーザーのコンテナ情報
/// </summary>
public class UserContainerInfo: InventoryDataBase
{
    /// <summary>
    /// コンテナID
    /// </summary>
    public long containerId { get; set; }

    /// <summary>
    /// 個数
    /// </summary>
    public int num { get; set;}
}
