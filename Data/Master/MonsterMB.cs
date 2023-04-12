using System.Collections.Generic;
using System.ComponentModel;
using PM.Enum.Gacha;
using PM.Enum.Monster;

/// <summary>
/// モンスターマスターデータ
/// </summary>
[Description("MonsterMB")]
public class MonsterMB : MasterBookBase
{
    /// <summary>
    /// 名前
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 属性
    /// </summary>
    public MonsterAttribute attribute { get; set; }

    /// <summary>
    /// レアリティ
    /// </summary>
    public MonsterRarity rarity { get; set; }

    /// <summary>
    /// ガチャモンスターか否か
    /// </summary>
    public bool isGachaMonster { get; set; }

    /// <summary>
    /// ガチャボックスタイプリスト
    /// </summary>
    public List<GachaBoxType> gachaBoxTypeList { get; set; }

    /// <summary>
    /// HP種族値
    /// </summary>
    public int hpBaseStatus { get; set; }

    /// <summary>
    /// 攻撃力種族値
    /// </summary>
    public int attackBaseStatus { get; set; }

    /// <summary>
    /// 防御力種族値
    /// </summary>
    public int defenseBaseStatus { get; set; }

    /// <summary>
    /// 素早さ種族値
    /// </summary>
    public int speedBaseStatus { get; set; }

    /// <summary>
    /// レベル1パッシブスキルID
    /// </summary>
    public long level1PassiveSkillId { get; set; }

    /// <summary>
    /// レベル2パッシブスキルID
    /// </summary>
    public long level2PassiveSkillId { get; set; }

    /// <summary>
    /// レベル3パッシブスキルID
    /// </summary>
    public long level3PassiveSkillId { get; set; }

    /// <summary>
    /// レベル1通常スキルID
    /// </summary>
    public long level1NormalSkillId { get; set; }

    /// <summary>
    /// レベル2通常スキルID
    /// </summary>
    public long level2NormalSkillId { get; set; }

    /// <summary>
    /// レベル3通常スキルID
    /// </summary>
    public long level3NormalSkillId { get; set; }

    /// <summary>
    /// レベル1アルティメットスキルID
    /// </summary>
    public long level1UltimateSkillId { get; set; }

    /// <summary>
    /// レベル2アルティメットスキルID
    /// </summary>
    public long level2UltimateSkillId { get; set; }

    /// <summary>
    /// レベル3アルティメットスキルID
    /// </summary>
    public long level3UltimateSkillId { get; set; }

    /// <summary>
    /// モンスタースプライトデータリスト
    /// </summary>
    public List<MonsterSpriteDataMI> monsterSpriteDataList { get; set; }

    /// <summary>
    /// スプライトの横方向サイズ
    /// </summary>
    public int spriteWidth { get; set; }

    /// <summary>
    /// スプライトの縦方向サイズ
    /// </summary>
    public int spriteHeight { get; set; }
}