using System.Collections.Generic;

public class UnlockContainerApiInterface
{
    public static string functionName = "UnlockContainer";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class UnlockContainerApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーコンテナIDリスト
    /// </summary>
    public List<string> userContainerIdList;
}

public class UnlockContainerApiResponse : PMApiResponseBase
{
    /// <summary>
    /// 付与されたアイテムリスト
    /// </summary>
    public List<ItemMI> itemList;
}
