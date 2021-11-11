using System.Collections.Generic;

public class GetBattleLogListApiInterface
{
    public static string functionName = "GetBattleLogList";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class GetBattleLogListApiRequest : PMApiRequestBase
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

public class GetBattleLogListApiResponse : PMApiResponseBase
{
    /// <summary>
    /// バトルログリスト
    /// </summary>
    public List<BattleLogInfo> battleLogList;
}
