public class DevelopGrantAllPropertyApiInterface
{
    public static string functionName = "DevelopGrantAllProperty";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class DevelopGrantAllPropertyApiRequest : PMApiRequestBase
{
}

public class DevelopGrantAllPropertyApiResponse : PMApiResponseBase
{
}
