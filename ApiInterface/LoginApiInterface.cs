﻿public class LoginApiInterface
{
    public static string functionName = "Login";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class LoginApiRequest : PMApiRequestBase
{
}

public class LoginApiResponse : PMApiResponseBase
{
    /// <summary>
    /// スタミナ
    /// </summary>
    public int stamina;
}
