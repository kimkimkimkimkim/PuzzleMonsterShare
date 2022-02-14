using System.Collections.Generic;
using PM.Enum.Battle;

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

    /// <summary>
    /// 勝敗
    /// </summary>
    public WinOrLose winOrLose;
}

public class ExecuteBattleApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーバトル情報
    /// </summary>
    public UserBattleInfo userBattle;
}
