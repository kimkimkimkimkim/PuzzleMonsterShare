public class FirstLoginApiInterface
{
    public static string functionName = "FirstLogin";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class FirstLoginApiRequest : PMApiRequestBase
{
}

public class FirstLoginApiResponse : PMApiResponseBase
{
}
