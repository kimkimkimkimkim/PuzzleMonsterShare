using PM.Enum.Monster;
#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    using UnityEngine;
#endif

/// <summary>
/// モンスタースプライト情報を扱うためのクラス
/// </summary>
public class MonsterSpriteDataMI
{
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

#if UNITY_EDITOR || UNITY_IOS || UNITY_ANDROID || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
    /// <summary>
    /// 対象スプライト
    /// </summary>
    public Sprite sprite { get; set; }
#endif
}