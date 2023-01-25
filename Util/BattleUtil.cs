// バトル関係のUtil
using System;
using System.Collections.Generic;

public static class BattleUtil
{
    public static BattleMonsterInfo GetBattleMonster(MonsterMB monster, int level, bool isPlayer, int index, int waveCount = 0){
        var status = MonsterUtil.GetMonsterStatus(monster, level);

        var battleMonster = new BattleMonsterInfo()
        {
            level = level,
            maxHp = status.hp,
            currentHp = status.hp,
            baseAttack = status.attack,
            baseDefense = status.defense,
            baseSpeed = status.speed,
            baseHeal = status.heal,
            maxEnergy = ConstManager.Battle.MAX_ENERGY_VALUE,
            currentEnergy = ConstManager.Battle.INITIAL_ENERGY_VALUE,
            battleConditionList = new List<BattleConditionInfo>(),
            passiveSkillExecuteCountList = new List<int>(),
            isActed = false,
            index = new BattleMonsterIndex() { isPlayer = isPlayer, index = index, waveCount = waveCount},
            monsterId = monster.id,
        };
        return battleMonster;
    }

    /// <summary>
    /// 能力値と倍率（負の値も含む）から計算後の値を返す
    /// </summary>
    public static float GetRatedValue(int baseValue, int rate)
    {
        var isPositive = rate >= 0;
        var absRate = Math.Abs(rate);

        if (isPositive)
        {
            return baseValue * (((float)(absRate + 100)) / 100);
        }
        else
        {
            return baseValue / (((float)(absRate + 100)) / 100);
        }
    }
}