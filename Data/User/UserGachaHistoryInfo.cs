using System;

/// <summary>
/// ユーザーガチャ履歴情報
/// </summary>
public class UserGachaHistoryInfo : UserDataBase {
    /// <summary>
    /// ガチャBOX詳細ID
    /// </summary>
    public long gachaBoxDetailId { get; set; }

    /// <summary>
    /// ガチャを実行した日時
    /// </summary>
    public DateTime executeDate { get; set; }

    /// <summary>
    /// 排出されたアイテム
    /// </summary>
    public ItemMI emittedItem { get; set; }
}
