public class ExecuteBattleApiInterface
{
    public static string functionName = "ExecuteBattle";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ExecuteBattleApiRequest : PMApiRequestBase
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

public class ExecuteBattleApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトルID
    /// </summary>
    public string userBattleId;
}
