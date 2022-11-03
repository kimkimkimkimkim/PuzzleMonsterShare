using System.Collections.Generic;
using System.Linq;
using PM.Enum.Item;
/// <summary>
/// ユーザー資産情報
/// </summary>
public class UserPropertyInfo: InventoryDataBase
{
    /// <summary>
    /// 資産ID
    /// </summary>
    public long propertyId { get; set; }

    /// <summary>
    /// 数
    /// </summary>
    public long num { get; set; }
}
