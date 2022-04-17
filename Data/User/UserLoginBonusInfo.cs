using System;
using System.Collections.Generic;

/// <summary>
/// ユーザーログインボーナス情報
/// </summary>
public class UserLoginBonusInfo : UserDataBase
{
    /// <summary>
    /// ログインボーナスID
    /// </summary>
    public long loginBonusId { get; set; }

    /// <summary>
    /// ログインした日時リスト
    /// </summary>
    public List<DateTime> loginDateList { get; set; }

    /// <summary>
    /// 該当のログインボーナスをすべて受け取り終わった日時
    /// </summary>
    public DateTime completedDate { get; set; }
}
