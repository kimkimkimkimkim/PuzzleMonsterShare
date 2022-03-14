using PM.Enum.Battle;

public class BattleChainParticipantInfo 
{
    /// <summary>
    /// モンスターインデックス
    /// </summary>
	public BattleMonsterIndex battleMonsterIndex { get; set; }
	
	/// <summary>
    /// バトルアクションタイプ
    /// </summary>
	public BattleActionType battleActionType { get; set; }
	
    /// <summary>
    /// 値（オプション）
	/// 状態異常カウントなど
    /// </summary>
	public int value { get; set; }
}
