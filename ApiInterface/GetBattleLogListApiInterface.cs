using System.Collections.Generic;

public class GetBattleResultApiInterface
{
    public static string functionName = "GetBattleResult";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class GetBattleResultApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーパーティID
    /// </summary>
    public string userMonsterPartyId;

    /// <summary>
    /// クエストID
    /// </summary>
    public long questId;
}

public class GetBattleResultApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトル結果情報
    /// </summary>
    public UserBattleResultInfo userBattleResult;
}