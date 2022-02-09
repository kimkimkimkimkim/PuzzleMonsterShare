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
    /// プレイヤー経験値の総獲得量
    /// </summary>
    public int totalPlayerExp { get; set; }

    /// <summary>
    /// ランク
    /// </summary>
    public int rank { get; set; }

    /// <summary>
    /// ユーザーバトルリスト
    /// </summary>
    public List<UserBattleInfo> userBattleList { get; set; } = new List<UserBattleInfo>();
}
