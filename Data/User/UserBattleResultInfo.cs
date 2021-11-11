using System.Collections.Generic;
using PM.Enum.Battle;

/// <summary>
/// ユーザーバトル結果情報
/// </summary>
public class UserBattleResultInfo
{
    /// <summary>
    /// バトルログリスト
    /// </summary>
    public List<BattleLogInfo> battleLogList { get; set; }

    /// <summary>
    /// 勝敗
    /// </summary>
    public WinOrLose winOrLose { get; set; }

    /// <summary>
    /// バトルをクライアント側で最後まで見たか否か
    /// </summary>
    public bool isFinished { get; set; }
}
