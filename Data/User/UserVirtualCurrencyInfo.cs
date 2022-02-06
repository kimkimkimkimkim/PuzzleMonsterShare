using System.Collections.Generic;
using PM.Enum.Item;

/// <summary>
/// ユーザー仮想通貨情報
/// </summary>
public class UserVirtualCurrencyInfo
{
    /// <summary>
    /// オーブ
    /// </summary>
    public int orb { get; set; } = 0;

    /// <summary>
    /// コイン
    /// </summary>
    public int coin { get; set; } = 0;

    /// <summary>
    /// プレイヤー経験値
    /// </summary>
    public int playerExp { get; set; } = 0;

    /// <summary>
    /// モンスター経験値
    /// </summary>
    public int monsterExp { get; set; } = 0;

    /// <summary>
    /// 仮想通貨とその個数の情報リスト
    /// </summary>
    public List<VirtualCurrencyNumInfo> virtualCurrencyNumList {
        get {
            return new List<VirtualCurrencyNumInfo>() {
                // オーブ
                new VirtualCurrencyNumInfo() {
                    virtualCurrencyId = (long)VirtualCurrencyType.OB,
                    num = this.orb,
                },
                // コイン
                new VirtualCurrencyNumInfo() {
                    virtualCurrencyId = (long)VirtualCurrencyType.CN,
                    num = this.coin,
                },
                // プレイヤー経験値
                new VirtualCurrencyNumInfo() {
                    virtualCurrencyId = (long)VirtualCurrencyType.PE,
                    num = this.playerExp,
                },
                // モンスター経験値
                new VirtualCurrencyNumInfo() {
                    virtualCurrencyId = (long)VirtualCurrencyType.ME,
                    num = this.monsterExp,
                },
            };
        }
    }

}

/// <summary>
/// 仮想通貨とその個数の情報
/// </summary>
public class VirtualCurrencyNumInfo{
    /// <summary>
    /// 仮想通貨ID
    /// </summary>
    public long virtualCurrencyId { get; set; }

    /// <summary>
    /// 個数
    /// </summary>
    public int num { get; set; }
}
