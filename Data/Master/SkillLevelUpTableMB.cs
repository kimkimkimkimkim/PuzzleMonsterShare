using PM.Enum.Battle;
using System.ComponentModel;

/// <summary>
/// スキルレベルテーブルマスタ
/// </summary>
[Description("SkillLevelUpTableMB")]
public class SkillLevelUpTableMB : MasterBookBase
{
    /// <summary>
    /// バトルアクションタイプ
    /// </summary>
    public BattleActionType battleActionType { get; set; }

    /// <summary>
    /// スキルレベル
    /// </summary>
    public int skillLevel { get; set; }

    /// <summary>
    /// 対象のスキルレベルになるのに必要なモンスターレベル
    /// </summary>
    public int requiredMonsterLevel { get; set; }
}
