public class DevelopGrantAllMonsterApiInterface
{
    public static string functionName = "DevelopGrantAllMonster";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class DevelopGrantAllMonsterApiRequest : PMApiRequestBase
{
}

public class DevelopGrantAllMonsterApiResponse : PMApiResponseBase
{
}
