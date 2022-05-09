using System.Collections.Generic;

public class ClearMissionApiInterface
{
    public static string functionName = "ClearMission";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ClearMissionApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ミッションIDリスト
    /// </summary>
    public List<long> missionIdList;
}

public class ClearMissionApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーミッション情報リスト
    /// </summary>
    public List<UserMissionInfo> userMissionList;

    /// <summary>
    /// 報酬アイテムリスト
    /// </summary>
    public List<ItemMI> rewardItemList;
}
