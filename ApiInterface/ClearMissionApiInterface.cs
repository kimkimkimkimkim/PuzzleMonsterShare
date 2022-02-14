using System.Collections.Generic;

public class ClearMissionApiInterface
{
    public static string functionName = "ClearMission";
}

// APIリクエストの変数はプロパティにしてはいけない！(シリアライズの関係)
public class ClearMissionApiRequest : PMApiRequestBase
{
    /// <summary>
    /// ミッションID
    /// </summary>
    public long missionId;
}

public class ClearMissionApiResponse : PMApiResponseBase
{
    /// <summary>
    /// ユーザーミッション情報
    /// </summary>
    public UserMissionInfo userMission;

    /// <summary>
    /// 報酬アイテムリスト
    /// </summary>
    public List<ItemMI> rewardItemList;
}
