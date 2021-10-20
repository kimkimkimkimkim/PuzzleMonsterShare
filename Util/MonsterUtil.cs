// モンスター関係のUtil
public static class MonsterUtil
{
    // マスタとレベルからステータスを計算し返す
    // 途中式はfloatで行い最後にintにキャスト
    public static MonsterStatus GetMonsterStatus(MonsterMB monster,int level){
        var hpSlope = (float)(monster.level100Hp - monster.level1Hp)/(100 - 1);
        var hpIntercept = monster.level1Hp - hpSlope;
        var hp = (int)(hpSlope * level + hpIntercept);

        var attackSlope = (float)(monster.level100Attack - monster.level1Attack)/(100 - 1);
        var attackIntercept = monster.level1Attack - attackSlope;
        var attack = (int)(attackSlope * level + attackIntercept);

        var healSlope = (float)(monster.level100Heal - monster.level1Heal)/(100 - 1);
        var healIntercept = monster.level1Heal - healSlope;
        var heal = (int)(healSlope * level + healIntercept);

        var defenseSlope = (float)(monster.level100Defense - monster.level1Defense) / (100 - 1);
        var defenseIntercept = monster.level1Defense - defenseSlope;
        var defense = (int)(defenseSlope * level + defenseIntercept);

        var speedSlope = (float)(monster.level100Speed - monster.level1Speed) / (100 - 1);
        var speedIntercept = monster.level1Speed - speedSlope;
        var speed = (int)(speedSlope * level + speedIntercept);

        return new MonsterStatus (){ hp = hp, attack = attack, heal = heal, defense = defense, speed = speed};
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