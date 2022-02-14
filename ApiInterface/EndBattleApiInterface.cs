using PM.Enum.Battle;

public class EndBattleApiInterface
{
    public static string functionName = "EndBattle";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class EndBattleApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーバトル情報ID
    /// </summary>
    public string userBattleId;
}

public class EndBattleApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;
}
