public class UseStaminaRecoveryApiInterface {
    public static string functionName = "UseStaminaRecovery";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class UseStaminaRecoveryApiRequest : PMApiRequestBase {
    /// <summary>
    /// スタミナ回復薬の使用個数
    /// </summary>
    public int num;
}

public class UseStaminaRecoveryApiResponse : PMApiResponseBase {
}
