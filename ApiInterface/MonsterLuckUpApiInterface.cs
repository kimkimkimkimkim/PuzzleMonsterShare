public class MonsterLuckUpApiInterface
{
    public static string functionName = "MonsterLuckUp";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class MonsterLuckUpApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーモンスターID
    /// </summary>
    public string userMonsterId;
    
    /// <summary>
    /// スタック消費量
    /// </summary>
    public int consumeStackNum;
}

public class MonsterLuckUpApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーモンスター
    /// </summary>
    public UserMonsterInfo userMonster;
}
