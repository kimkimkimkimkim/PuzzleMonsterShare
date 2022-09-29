using System.Collections.Generic;

public class GrantItemsToUserApiInterface
{
    public static string functionName = "GrantItemsToUser";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class GrantItemsToUserApiRequest : PMApiRequestBase
{
    /// <summary>
    /// 付与するアイテムのアイテムIDリスト
    /// </summary>
    public List<string> itemIdList;
}

public class GrantItemsToUserApiResponse : PMApiResponseBase
{
    /// <summary>
    /// 取得したアイテムリスト
    /// </summary>
    public List<ItemMI> itemList { get; set;}
}
