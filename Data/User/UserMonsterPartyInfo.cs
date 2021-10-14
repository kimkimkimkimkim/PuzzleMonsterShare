using System.Collections.Generic;
using System.Linq;

public class UserMonsterPartyInfo
{
    /// <summary>
    /// ID
    /// </summary>
    public string id { get; set; }

    /// <summary>
    /// パーティーインデックス（0 ~ MAX_PARTY_NUM - 1）
    /// </summary>
    public int partyIndex { get; set; }

    /// <summary>
    /// ユーザーモンスターIDリスト（空の場合はnullが入っている）
    /// </summary>
    public List<string> userMonsterIdList { get; set; }

    /// <summary>
    /// コピーを作成する
    /// </summary>
    public UserMonsterPartyInfo Clone()
    {
        return new UserMonsterPartyInfo()
        {
            id = id,
            partyIndex = partyIndex,
            userMonsterIdList = new List<string>(userMonsterIdList),
        };
    }

    /// <summary>
    /// 指定したユーザーパーティ情報を等しいか返す
    /// </summary>
    public bool IsSame(UserMonsterPartyInfo userMonsterParty)
    {
        if (id != userMonsterParty.id) return false;
        if (partyIndex != userMonsterParty.partyIndex) return false;
        if (!userMonsterIdList.SequenceEqual(userMonsterParty.userMonsterIdList)) return false;
        return true;
    }
}
