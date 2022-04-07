using System;

// モンスター関係のUtil
public static class MonsterUtil
{
    // マスタとレベルからステータスを計算し返す
    // 途中式はfloatで行い最後にintにキャスト
    public static MonsterStatus GetMonsterStatus(MonsterMB monster,int level){
        var hp = (int)Math.Round((monster.hpBaseStatus * monster.hpBaseStatus + 94) * level / 100d + level + 10) * 4;
        var attack = (int)Math.Round((monster.attackBaseStatus * monster.attackBaseStatus + 94) * level / 100d + 5);
        var defense = (int)Math.Round((monster.defenseBaseStatus * monster.defenseBaseStatus + 94) * level / 100d + 5);
        var speed = (int)Math.Round((monster.speedBaseStatus * monster.speedBaseStatus + 94) * level / 100d + 5);

        return new MonsterStatus (){ hp = hp, attack = attack, heal = 0, defense = defense, speed = speed};
    }

}

// モンスターステータス
public class MonsterStatus {
    public int hp { get; set; }
    public int attack { get; set; }
    public int heal { get; set; }
    public int defense { get; set; }
    public int speed { get; set; }
}