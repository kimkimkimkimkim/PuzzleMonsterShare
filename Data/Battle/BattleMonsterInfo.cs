using System.Collections.Generic;

public class BattleMonsterInfo
{
    /// <summary>
    /// モンスターID
    /// </summary>
    public long monsterId { get; set; }

    /// <summary>
    /// バトルモンスターインデックス
    /// </summary>
    public BattleMonsterIndex index { get; set; }

    /// <summary>
    /// レベル
    /// </summary>
    public int level{ get; set; }
     
    /// <summary>
    /// 最大体力
    /// </summary>
    public int maxHp{ get; set; }

    /// <summary>
    /// 現在の体力
    /// </summary>
    public int currentHp { get; set; }

    /// <summary>
    /// 基準攻撃力
    /// </summary>
    public int baseAttack{ get; set; }

    /// <summary>
    /// 基準防御力
    /// </summary>
    public int baseDefense{ get; set; }

    /// <summary>
    /// 基準スピード
    /// </summary>
    public int baseSpeed{ get; set; }
     
    /// <summary>
    /// 基準回復力
    /// </summary>
    public int baseHeal{ get; set; }
    
    /// <summary>
    /// 最大のエネルギー
    /// </summary>
    public int maxEnergy{ get; set; }
     
    /// <summary>
    /// 現在のエネルギー
    /// </summary>
    public int currentEnergy{ get; set; }

    /// <summary>
    /// スキルダメージ率
    /// </summary>
    public int shield { get; set; }

    /// <summary>
    /// スキルダメージ率
    /// </summary>
    public int ultimateSkillDamageRate { get; set; }

    /// <summary>
    /// ブロック率
    /// </summary>
    public int blockRate { get; set; }

    /// <summary>
    /// クリティカル率
    /// </summary>
    public int criticalRate { get; set; }

    /// <summary>
    /// クリティカルダメージ
    /// </summary>
    public int criticalDamage { get; set; }

    /// <summary>
    /// 強化効果免疫率
    /// </summary>
    public int buffResistRate { get; set; }

    /// <summary>
    /// 弱体効果免疫率
    /// </summary>
    public int debuffResistRate { get; set; }

    /// <summary>
    /// ダメージ軽減率
    /// </summary>
    public int damageResistRate { get; set; }

    /// <summary>
    /// ラックダメージ率
    /// </summary>
    public int luckDamageRate { get; set; }

    /// <summary>
    /// 神聖ダメージ率
    /// </summary>
    public int holyDamageRate { get; set; }

    /// <summary>
    /// エネルギー上昇率
    /// </summary>
    public int energyUpRate { get; set; }

    /// <summary>
    /// 回復率（回復をする際の回復量上昇率）
    /// </summary>
    public int healingRate { get; set; }

    /// <summary>
    /// 被回復率（回復を受ける際の回復量上昇率）
    /// </summary>
    public int healedRate { get; set; }

    /// <summary>
    /// 状態異常リスト
    /// </summary>
    public List<BattleConditionInfo> battleConditionList{ get; set; }
    
    /// <summary>
    /// このターンすでに行動しているか否か
    /// </summary>
    public bool isActed{ get; set; }

    /// <summary>
    /// 戦闘不能か否か
    /// </summary>
    public bool isDead { get; set; }
}

public static class BattleMonsterInfoExtentions
{ 
    public static void ChangeHp(this BattleMonsterInfo monster, int value)
    {
        var tempHp = monster.currentHp + value;
        if (tempHp > monster.maxHp)
        {
            monster.currentHp = monster.maxHp;
        }
        else if (tempHp < 0)
        {
            monster.currentHp = 0;
        }
        else
        {
            monster.currentHp = tempHp;
        }
    }

    public static void ChangeEnergy(this BattleMonsterInfo monster, int value)
    {
        var tempEnergy = monster.currentEnergy + value;
        if (tempEnergy > ConstManager.Battle.MAX_ENERGY_VALUE)
        {
            monster.currentEnergy = ConstManager.Battle.MAX_ENERGY_VALUE;
        }
        else if (tempEnergy < 0)
        {
            monster.currentEnergy = 0;
        }
        else
        {
            monster.currentEnergy = tempEnergy;
        }
    }

    public static float currentAttack(this BattleMonsterInfo monster)
    {
        return monster.baseAttack;
    }

    public static float currentDefense(this BattleMonsterInfo monster)
    {
        return monster.baseDefense;
    }

    public static float currentSpeed(this BattleMonsterInfo monster)
    {
        return monster.baseSpeed;
    }

    public static float currentHeal(this BattleMonsterInfo monster)
    {
        return monster.baseHeal;
    }
}
