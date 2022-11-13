public class RewardAdGrantRewardApiInterface
{
    public static string functionName = "RewardAdGrantReward";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class RewardAdGrantRewardApiRequest : PMApiRequestBase
{
    /// <summary>
    /// リワード広告ID
    /// </summary>
    public long rewardAdId;
}

public class RewardAdGrantRewardApiResponse : PMApiResponseBase
{
    /// <summary>
    /// 当選したインデックス
    /// </summary>
    public int electedIndex { get; set; }
}
