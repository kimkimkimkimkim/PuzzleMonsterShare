public class BattleMonsterIndexDataSet
{
    /// <summary>
    /// スキルターゲットか否か
    /// </summary>
    public bool isSkillTarget { get; set; }

    /// <summary>
    /// 確率でスキル効果が発動しなかったか否か
    /// </summary>
    public bool isMissed { get; set; }

    /// <summary>
    /// バトルモンスターインデックス
    /// </summary>
    public BattleMonsterIndex battleMonsterIndex { get; set; }
}