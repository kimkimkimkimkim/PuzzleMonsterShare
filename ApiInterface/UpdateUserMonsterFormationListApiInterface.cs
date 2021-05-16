using System.Collections.Generic;

public class UpdateUserMonsterFormationListApiInterface
{
    public static string functionName = "UpdateUserMonsterFormationList";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class UpdateUserMonsterFormationListApiRequest : PMApiRequestBase
{
    /// <summary>
    /// パーティID
    /// </summary>
    public int partyId;

    /// <summary>
    /// ユーザーモンスターIDリスト
    /// </summary>
    public List<string> userMonsterIdList;
}

public class UpdateUserMonsterFormationListApiResponse : PMApiResponseBase
{
}
