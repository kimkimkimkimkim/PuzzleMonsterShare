// バトル関係のUtil
using System.Collections.Generic;

public static class BattleUtil
{
    public static BattleMonsterInfo GetBattleMonster(MonsterMB monster, int level, bool isPlayer, int index){
        var status = MonsterUtil.GetMonsterStatus(monster, level);

        return new BattleMonsterInfo()
        {
            level = level,
            maxHp = status.hp,
            currentHp = status.hp,
            baseAttack = status.attack,
            currentAttack = status.attack,
            baseDefense = status.defense,
            currentDefense = status.defense,
            baseSpeed = status.speed,
            currentSpeed = status.speed,
            baseHeal = status.heal,
            currentHeal = status.heal,
            maxCt = ConstManager.Battle.MAX_CT_VALUE,
            currentCt = 0,
            battleConditionList = new List<BattleConditionInfo>(),
            isActed = false,
            index = new BattleMonsterIndex() { isPlayer = isPlayer, index = index},
        };
    }
}