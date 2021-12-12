using PM.Enum.Battle;

public class EndBattleApiInterface
{
    public static string functionName = "EndBattle";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class EndBattleApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーパーティID
    /// </summary>
    public string userMonsterPartyId;

    /// <summary>
    /// クエストID
    /// </summary>
    public long questId;

    /// <summary>
    /// 勝敗
    /// </summary>
    public WinOrLose winOrLose;
}

public class EndBattleApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;
}
