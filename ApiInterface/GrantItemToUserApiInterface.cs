using System.Collections.Generic;

public class GrantItemToUserApiInterface
{
    public static string functionName = "GrantItemToUser";
}

public class GrantItemToUserApiRequest
{
    /// <summary>
    /// 付与するアイテムのアイテムIDリスト
    /// </summary>
    public List<string> itemIdList { get; set; }
}
