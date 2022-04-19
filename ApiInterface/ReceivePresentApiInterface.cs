using System.Collections.Generic;

public class ReceivePresentApiInterface
{
    public static string functionName = "ReceivePresent";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ReceivePresentApiRequest : PMApiRequestBase
{
    /// <summary>
    /// 受け取るユーザープレゼントIDリスト
    /// </summary>
    public List<string> userPresentIdList;
}

public class ReceivePresentApiResponse : PMApiResponseBase
{
    /// <summary>
    /// 受け取ったユーザープレゼント情報リスト
    /// </summary>
    public List<UserPresentInfo> userPresentList;
}
