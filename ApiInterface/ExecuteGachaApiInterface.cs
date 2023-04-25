using System.Collections.Generic;

public class ExecuteGachaApiInterface
{
    public static string functionName = "ExecuteGacha";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ExecuteGachaApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ガチャBOXID
    /// </summary>
    public long gachaBoxId;

    /// <summary>
    /// ガチャBOX詳細ID
    /// </summary>
    public long gachaBoxDetailId;
}

public class ExecuteGachaApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ガチャ報酬アイテムリスト
    /// </summary>
    public List<GachaRewardItemMI> rewardItemList;
}
