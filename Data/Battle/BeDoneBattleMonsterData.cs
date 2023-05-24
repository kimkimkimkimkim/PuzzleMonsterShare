using PM.Enum.Monster;
using System.Collections.Generic;

/// <summary>
/// スキル対象となったモンスターが何をされたのかを表す
/// </summary>
public class BeDoneBattleMonsterData {
    /// <summary>
    /// 対象のモンスターのインデックス
    /// </summary>
    public BattleMonsterIndex battleMonsterIndex { get; set; }

    /// <summary>
    /// HPの変化量
    /// ダメージはマイナス、回復はプラス
    /// </summary>
    public int hpChanges { get; set; }

    /// <summary>
    /// エネルギーの変化量
    /// </summary>
    public int energyChanges { get; set; }

    /// <summary>
    /// 失敗したか否か
    /// </summary>
    public bool isMissed { get; set; }

    /// <summary>
    /// クリティカルか否か
    /// </summary>
    public bool isCritical { get; set; }

    /// <summary>
    /// ブロックしたか否か
    /// </summary>
    public bool isBlocked { get; set; }

    /// <summary>
    /// 属性相性タイプ
    /// </summary>
    public MonsterAttributeCompatibilityType monsterAttributeCompatibilityType { get; set; }

    /// <summary>
    /// 状態異常情報リスト
    /// </summary>
    public List<BattleConditionInfo> battleConditionList { get; set; }
}
