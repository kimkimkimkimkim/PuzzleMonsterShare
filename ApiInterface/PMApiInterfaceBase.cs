// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class PMApiRequestBase
{

}

public class PMApiResponseBase
{
    public PMApiException exception;
}

public enum PMErrorCode
{
    Success = 0,
    Unknown = 1,
}