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
    /// ラック上昇量
    /// </summary>
    public int luckUpNum;
}

public class MonsterLuckUpApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーモンスター
    /// </summary>
    public UserMonsterInfo userMonster;
}
