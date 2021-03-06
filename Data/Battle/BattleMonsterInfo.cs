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

    /// <summary>
    /// 直近で自分に攻撃してきたモンスターのモンスターインデックス
    /// </summary>
    public BattleMonsterIndex currentBeDoneAttackedMonsterIndex { get; set; }
    
    /// <summary>
    /// 状態異常カウンター（付与されるたびにインクリメント）
    /// </summary>
    public int battleConditionCount { get; set; }
    
    /// <summary>
    /// パッシブスキル発動回数
    /// </summary>
    public int passiveSkillExecuteCount { get; set; }
    
    /// <summary>
    /// バトル中の合計与ダメージ量
    /// </summary>
    public int totalGiveDamage { get; set; }
    
    /// <summary>
    /// バトル中の合計被ダメージ量
    /// </summary>
    public int totalTakeDamage { get; set; }
    
    /// <summary>
    /// バトル中の合計与回復量
    /// </summary>
    public int totalHealing { get; set; }
}
