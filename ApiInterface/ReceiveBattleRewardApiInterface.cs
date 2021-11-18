public class ReceiveBattleRewardApiInterface
{
    public static string functionName = "ReceiveBattleReward";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ReceiveBattleRewardApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;
}

public class ReceiveBattleRewardApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;
}
