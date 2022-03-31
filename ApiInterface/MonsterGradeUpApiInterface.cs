public class MonsterGradeUpApiInterface
{
    public static string functionName = "MonsterGradeUp";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class MonsterGradeUpApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ユーザーモンスターID
    /// </summary>
    public string userMonsterId;
}

public class MonsterGradeUpApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーモンスター
    /// </summary>
    public UserMonsterInfo userMonster;
}
