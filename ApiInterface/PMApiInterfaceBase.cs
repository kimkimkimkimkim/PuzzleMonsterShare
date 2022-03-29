// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
using System.Collections.Generic;

public class PMApiRequestBase
{

}

public class PMApiResponseBase
{
    public PMApiStatus status;
    public PMApiException exception;
    public List<UserNotificationInfo> userNotificationList;
}

/// <summary>
/// APIのエラーコード
/// </summary>
public enum PMErrorCode
{
    Unknown = 1,
}

/// <summary>
/// APIのステータスコード
/// </summary>
public enum PMApiStatus
{
    /// <summary>
    /// APIの通信が正常に行われた場合
    /// </summary>
    OK = 0,

    /// <summary>
    /// APIの処理実行時に何らかなのロジックエラーが発生した場合
    /// </summary>
    Error = 1,

    /// <summary>
    /// 認証に失敗した場合（セッション切れも含む）
    /// </summary>
    Unauthorized = 2,

    /// <summary>
    /// メンテナンスの場合
    /// </summary>
    Maintenance = 3,

    /// <summary>
    /// クライアントが強制アップデート対象の場合
    /// </summary>
    InvalidClientVersion = 4,

    /// <summary>
    /// APIの新しいバージョンが稼働済
    /// </summary>
    DeprecatedServerApi = 5,

    /// <summary>
    /// 停止アカウントであった場合
    /// </summary>
    BannedAccount = 6,
}