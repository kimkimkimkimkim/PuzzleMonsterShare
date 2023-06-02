using System;
using System.Collections.Generic;

/// <summary>
/// ユーザーお知らせ情報
/// </summary>
public class UserNewsInfo : UserDataBase {
    /// <summary>
    /// お知らせID
    /// </summary>
    public long newsId { get; set; }

    /// <summary>
    /// 配信された日時
    /// </summary>
    public DateTime date { get; set; }
}
