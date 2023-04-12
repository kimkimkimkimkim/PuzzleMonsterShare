using PM.Enum.Monster;
using UnityEngine;

/// <summary>
/// モンスタースプライト情報を扱うためのクラス
/// </summary>
public class MonsterSpriteDataMI
{
    /// <summary>
    /// 対象スプライトの横方向サイズ
    /// </summary>
    public int width { get; set; }

    /// <summary>
    /// 対象スプライトの縦方向サイズ
    /// </summary>
    public int height { get; set; }

    /// <summary>
    /// 対象スプライトのスプライトアトラス内でのx軸方向インデックス（左上基準）
    /// </summary>
    public int xIndex { get; set; }

    /// <summary>
    /// 対象スプライトのスプライトアトラス内でのy軸方向インデックス（左上基準）
    /// </summary>
    public int yIndex { get; set; }

    /// <summary>
    /// 対象のモンスターステイト
    /// </summary>
    public MonsterState monsterState { get; set; }

    /// <summary>
    /// 対象のモンスターステイトアニメーション内でのインデックス
    /// </summary>
    public int stateIndex { get; set; }

    /// <summary>
    /// 対象スプライトのスプライトアトラス内でのインデックス
    /// </summary>
    public int spriteAtlasIndex { get; set; }

    /// <summary>
    /// 対象スプライト
    /// </summary>
    public Sprite sprite { get; set; }
}