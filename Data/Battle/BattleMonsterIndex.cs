public class BattleMonsterIndex
{
    /// <summary>
    /// プレイヤーのモンスターか否か
    /// </summary>
    public bool isPlayer { get; set; }

    /// <summary>
    /// インデックス
    /// </summary>
    public int index { get; set; }

    /// <summary>
    /// ウェーブ数
    /// 敵モンスター用
    /// </summary>
    public int waveCount { get; set; }

    public BattleMonsterIndex()
    { }

    public BattleMonsterIndex(BattleMonsterIndex battleMonsterIndex)
    {
        this.isPlayer = battleMonsterIndex.isPlayer;
        this.index = battleMonsterIndex.index;
        this.waveCount = battleMonsterIndex.waveCount;
    }

    public bool IsSame(BattleMonsterIndex battleMonsterIndex)
    {
        return battleMonsterIndex != null && this.isPlayer == battleMonsterIndex.isPlayer && this.index == battleMonsterIndex.index && this.waveCount == battleMonsterIndex.waveCount;
    }
}