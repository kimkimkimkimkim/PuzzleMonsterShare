/// <summary>
/// スキル対象となったモンスターが何をされたのかを表す
/// </summary>
public class BeDoneBattleMonsterData
{
    /// <summary>
    /// 対象のモンスターのインデックス
    /// </summary>
    public BattleMonsterIndex battleMonsterIndex { get; set; }

    /// <summary>
    /// HPの変化量
    /// </summary>
    public int hpChanges { get; set; }

    /// <summary>
    /// 失敗したか否か
    /// </summary>
    public bool isMissed { get; set; }
}