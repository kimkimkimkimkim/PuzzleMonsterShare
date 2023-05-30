using System.Collections.Generic;

public class PresentGrantApiInterface
{
    public static string functionName = "PresentGrant";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class PresentGrantApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public List<ItemMI> itemList;

    /// <summary>
    /// メッセージ
    /// </summary>
    public string message;
}

public class PresentGrantApiResponse : PMApiResponseBase
{
}
