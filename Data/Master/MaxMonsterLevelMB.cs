using System.ComponentModel;
using PM.Enum.Monster;

/// <summary>
/// モンスターの最大レベルマスタ
/// </summary>
[Description("MaxMonsterLevelMB")]
public class MaxMonsterLevelMB : MasterBookBase
{
    /// <summary>
    /// モンスターのレアリティ
    /// </summary>
    public MonsterRarity monsterRarity { get; set; }
    
    /// <summary>
    /// モンスターのグレード
    /// </summary>
    public int monsterGrade { get; set; }
    
    /// <summary>
    /// モンスターの最大レベル
    /// </summary>
    public int maxMonsterLevel { get; set; }
}
