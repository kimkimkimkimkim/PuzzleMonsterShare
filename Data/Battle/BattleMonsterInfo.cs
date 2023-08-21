using System.Collections.Generic;

public class BattleMonsterInfo {
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
    public int level { get; set; }

    /// <summary>
    /// 最大体力
    /// </summary>
    public int maxHp { get; set; }

    /// <summary>
    /// 現在の体力
    /// </summary>
    public int currentHp { get; set; }

    /// <summary>
    /// 基準攻撃力
    /// </summary>
    public int baseAttack { get; set; }

    /// <summary>
    /// 現在の攻撃力
    /// </summary>
    public int currentAttack { get; set; }

    /// <summary>
    /// 基準防御力
    /// </summary>
    public int baseDefense { get; set; }

    /// <summary>
    /// 現在の防御力
    /// </summary>
    public int currentDefense { get; set; }

    /// <summary>
    /// 基準スピード
    /// </summary>
    public int baseSpeed { get; set; }

    /// <summary>
    /// 現在のスピード
    /// </summary>
    public int currentSpeed { get; set; }

    /// <summary>
    /// 基準回復力
    /// </summary>
    public int baseHeal { get; set; }

    /// <summary>
    /// 現在の回復力
    /// </summary>
    public int currentHeal { get; set; }

    /// <summary>
    /// 基準シールド
    /// </summary>
    public int baseShield { get; set; }

    /// <summary>
    /// 現在のシールド
    /// </summary>
    public int currentShield { get; set; }

    /// <summary>
    /// 基準スキルダメージ率
    /// </summary>
    public int baseUltimateSkillDamageRate { get; set; }

    /// <summary>
    /// 現在のスキルダメージ率
    /// </summary>
    public int currentUltimateSkillDamageRate { get; set; }

    /// <summary>
    /// 基準ブロック率
    /// </summary>
    public int baseBlockRate { get; set; }

    /// <summary>
    /// 現在のブロック率
    /// </summary>
    public int currentBlockRate { get; set; }

    /// <summary>
    /// 基準クリティカル率
    /// </summary>
    public int baseCriticalRate { get; set; }

    /// <summary>
    /// 現在のクリティカル率
    /// </summary>
    public int currentCriticalRate { get; set; }

    /// <summary>
    /// 基準クリティカルダメージ
    /// </summary>
    public int baseCriticalDamage { get; set; }

    /// <summary>
    /// 現在のクリティカルダメージ
    /// </summary>
    public int currentCriticalDamage { get; set; }

    /// <summary>
    /// 基準強化効果耐性
    /// </summary>
    public int baseBuffResistRate { get; set; }

    /// <summary>
    /// 現在の強化効果耐性
    /// </summary>
    public int currentBuffResistRate { get; set; }

    /// <summary>
    /// 基準弱体効果耐性
    /// </summary>
    public int baseDebuffResistRate { get; set; }

    /// <summary>
    /// 現在の弱体効果耐性
    /// </summary>
    public int currentDebuffResistRate { get; set; }

    /// <summary>
    /// 基準ダメージ軽減率
    /// </summary>
    public int baseDamageResistRate { get; set; }

    /// <summary>
    /// 現在のダメージ軽減率
    /// </summary>
    public int currentDamageResistRate { get; set; }

    /// <summary>
    /// 基準ラックダメージ率
    /// </summary>
    public int baseLuckDamageRate { get; set; }

    /// <summary>
    /// 現在のラックダメージ率
    /// </summary>
    public int currentLuckDamageRate { get; set; }

    /// <summary>
    /// 基準神聖ダメージ率
    /// </summary>
    public int baseHolyDamageRate { get; set; }

    /// <summary>
    /// 現在の神聖ダメージ率
    /// </summary>
    public int currentHolyDamageRate { get; set; }

    /// <summary>
    /// 基準エネルギー上昇率
    /// </summary>
    public int baseEnergyUpRate { get; set; }

    /// <summary>
    /// 現在のエネルギー上昇率
    /// </summary>
    public int currentEnergyUpRate { get; set; }

    /// <summary>
    /// 基準被回復率
    /// </summary>
    public int baseHealedRate { get; set; }

    /// <summary>
    /// 現在の被回復率
    /// </summary>
    public int currentHealedRate { get; set; }

    /// <summary>
    /// 基準攻撃精度
    /// </summary>
    public int baseAttackAccuracy { get; set; }

    /// <summary>
    /// 現在の攻撃精度
    /// </summary>
    public int currentAttackAccuracy { get; set; }

    /// <summary>
    /// 基準アーマー
    /// </summary>
    public int baseArmor { get; set; }

    /// <summary>
    /// 現在のアーマー
    /// </summary>
    public int currentArmor { get; set; }

    /// <summary>
    /// 基準アーマーブレイク率
    /// </summary>
    public int baseArmorBreakRate { get; set; }

    /// <summary>
    /// 現在のアーマーブレイク率
    /// </summary>
    public int currentArmorBreakRate { get; set; }

    /// <summary>
    /// 基準与回復率
    /// </summary>
    public int baseHealingRate { get; set; }

    /// <summary>
    /// 現在の与回復率
    /// </summary>
    public int currentHealingRate { get; set; }

    /// <summary>
    /// 基準防御貫通率
    /// </summary>
    public int baseDefensePenetratingRate { get; set; }

    /// <summary>
    /// 現在の防御貫通率
    /// </summary>
    public int currentDefensePenetratingRate { get; set; }

    /// <summary>
    /// 最大のエネルギー
    /// </summary>
    public int maxEnergy { get; set; }

    /// <summary>
    /// 現在のエネルギー
    /// </summary>
    public int currentEnergy { get; set; }

    /// <summary>
    /// 基準状態異常リスト
    /// </summary>
    public List<BattleConditionInfo> baseBattleConditionList { get; set; }

    /// <summary>
    /// 状態異常リスト
    /// </summary>
    public List<BattleConditionInfo> battleConditionList { get; set; }

    /// <summary>
    /// このターンすでに行動しているか否か
    /// </summary>
    public bool isActed { get; set; }

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
    /// パッシブスキル発動回数リスト
    /// passiveSkillEffectListのIndexに対応して発動回数を格納する
    /// </summary>
    public List<int> passiveSkillExecuteCountList { get; set; }

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

    /// <summary>
    /// 通常スキル
    /// </summary>
    public NormalSkillMB normalSkill { get; set; }

    /// <summary>
    /// アルティメットスキル
    /// </summary>
    public UltimateSkillMB ultimateSkill { get; set; }

    /// <summary>
    /// パッシブスキル
    /// </summary>
    public PassiveSkillMB passiveSkill { get; set; }
}
