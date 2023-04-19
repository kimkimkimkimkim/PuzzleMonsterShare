using System.ComponentModel;
using System.Collections.Generic;
using PM.Enum.Gacha;

[Description("GachaBoxMB")]
public class GachaBoxMB : MasterBookBase {
    /// <summary>
    /// ガチャ筐体名
    /// </summary>
    public string title { get; set; }

    /// <summary>
    /// ガチャ開催タイプ
    /// </summary>
    public GachaOpenType openType { get; set; }

    /// <summary>
    /// 排出対象のガチャBOXタイプリスト
    /// </summary>
    public List<GachaBoxType> gachaBoxTypeList { get; set; }

    /// <summary>
    /// ピックアップ対象のモンスターIDリスト
    /// </summary>
    public List<long> pickUpMonsterIdList { get; set; }

    /// <summary>
    /// 通常枠抽選時のレアリティ別排出確率
    /// </summary>
    public EmisionPercentByRarity normalEmissionPercentByRarity { get; set; }

    /// <summary>
    /// SR以上確定枠抽選時のレアリティ別排出確率
    /// </summary>
    public EmisionPercentByRarity upperSrEmissionPercentByRarity { get; set; }

    /// <summary>
    /// SSR確定枠抽選時のレアリティ別排出確率
    /// </summary>
    public EmisionPercentByRarity upperSsrEmissionPercentByRarity { get; set; }
}
