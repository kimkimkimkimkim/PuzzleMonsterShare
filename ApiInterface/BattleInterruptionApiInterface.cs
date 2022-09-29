public class BattleInterruptionApiInterface
{
    public static string functionName = "BattleInterruption";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class BattleInterruptionApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーバトルID
    /// </summary>
    public string userBattleId;
}

public class BattleInterruptionApiResponse : PMApiResponseBase
{
}
