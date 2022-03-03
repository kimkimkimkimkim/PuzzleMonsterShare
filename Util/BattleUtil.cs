// バトル関係のUtil
using System.Collections.Generic;

public static class BattleUtil
{
    public static BattleMonsterInfo GetBattleMonster(MonsterMB monster, int level, bool isPlayer, int index){
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
            isActed = false,
            index = new BattleMonsterIndex() { isPlayer = isPlayer, index = index},
            monsterId = monster.id,
        };
        return battleMonster;
    }
}