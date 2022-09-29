public class DevelopGrantAllVirtualCurrencyApiInterface
{
    public static string functionName = "DevelopGrantAllVirtualCurrency";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class DevelopGrantAllVirtualCurrencyApiRequest : PMApiRequestBase
{
}

public class DevelopGrantAllVirtualCurrencyApiResponse : PMApiResponseBase
{
}
