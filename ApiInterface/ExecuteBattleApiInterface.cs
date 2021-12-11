using System.Collections.Generic;

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
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;

    /// <summary>
    /// バトルログリスト
    /// </summary>
    public List<BattleLogInfo> battleLogList { get; set; }
}
