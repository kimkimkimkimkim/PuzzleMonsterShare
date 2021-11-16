using System;
using System.Collections.Generic;

/// <summary>
/// ユーザーデータ情報
/// 新しくパラメータを追加した際はEnum.UserDataKeyの追加を忘れないように
/// </summary>
public class UserDataInfo
{
    /// <summary>
    /// ユーザーモンスターパーティーリスト
    /// </summary>
    public List<UserMonsterPartyInfo> userMonsterPartyList { get; set; } = new List<UserMonsterPartyInfo>();

    /// <summary>
    /// 前回のログイン日時
    /// </summary>
    public DateTime lastLoginDateTime { get; set; } = DateTimeUtil.Epoch;

    /// <summary>
    /// 前回スタミナ計算を行った日時
    /// </summary>
    public DateTime lastCalculatedStaminaDateTime { get; set; } = DateTimeUtil.Epoch;

    /// <summary>
    /// スタミナ
    /// </summary>
    public int stamina { get; set; }

    /// <summary>
    /// ランク
    /// </summary>
    public int rank { get; set; }

    /// <summary>
    /// ユーザーバトル結果リスト
    /// </summary>
    public List<UserBattleResultInfo> userBattleResultList { get; set; } = new List<UserBattleResultInfo>();
}
