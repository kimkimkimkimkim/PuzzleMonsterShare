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
    /// ユーザーバトルリスト
    /// </summary>
    public List<UserBattleInfo> userBattleList { get; set; } = new List<UserBattleInfo>();

    /// <summary>
    /// ユーザーミッションリスト
    /// </summary>
    public List<UserMissionInfo> userMissionList { get; set; } = new List<UserMissionInfo>();

    /// <summary>
    /// ユーザープレゼントリスト
    /// </summary>
    public List<UserPresentInfo> userPresentList { get; set; } = new List<UserPresentInfo>();

    /// <summary>
    /// ユーザーログインボーナスリスト
    /// </summary>
    public List<UserLoginBonusInfo> userLoginBonusList{ get; set; } = new List<UserLoginBonusInfo>();

    /// <summary>
    /// ユーザーモンスターリスト
    /// </summary>
    public List<UserMonsterInfo> userMonsterList { get; set; } = new List<UserMonsterInfo>();

    /// <summary>
    /// ユーザー資産リスト
    /// </summary>
    public List<UserPropertyInfo> userPropertyList { get; set; } = new List<UserPropertyInfo>();
}
