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
    /// 状態異常カウント（アクションタイプが状態異常効果の時用）
    /// 状態異常判別用
    /// </summary>
    public int battleConditionCount { get; set; }

    /// <summary>
    /// トリガーの起因となったモンスターのモンスターインデックス（反撃系用）
    /// </summary>
	public BattleMonsterIndex targetBattleMonsterIndex { get; set; }

    /// <summary>
    /// トリガーの起因となったモンスターのバトルアクションタイプ（反撃系用）
    /// </summary>
    public BattleActionType targetBattleActionType { get; set; }

    /// <summary>
    /// トリガーの起因となったモンスターの状態異常カウント（アクションタイプが状態異常効果の時用）（反撃系用）
    /// 状態異常判別用
    /// </summary>
    public int targetBattleConditionCount { get; set; }

    public bool IsSame(BattleChainParticipantInfo battleChainParticipant)
    {
        if(targetBattleMonsterIndex == null)
        {
            return
                battleMonsterIndex.IsSame(battleChainParticipant.battleMonsterIndex) &&
                battleActionType == battleChainParticipant.battleActionType &&
                battleConditionCount == battleChainParticipant.battleConditionCount &&
                targetBattleMonsterIndex == battleChainParticipant.targetBattleMonsterIndex &&
                targetBattleActionType == battleChainParticipant.targetBattleActionType &&
                targetBattleConditionCount == battleChainParticipant.targetBattleConditionCount;
        }
        else
        {
            return
                battleMonsterIndex.IsSame(battleChainParticipant.battleMonsterIndex) &&
                battleActionType == battleChainParticipant.battleActionType &&
                battleConditionCount == battleChainParticipant.battleConditionCount &&
                targetBattleMonsterIndex.IsSame(battleChainParticipant.targetBattleMonsterIndex) &&
                targetBattleActionType == battleChainParticipant.targetBattleActionType &&
                targetBattleConditionCount == battleChainParticipant.targetBattleConditionCount;
        }
    }
}
