using PM.Enum.Battle;
using System.ComponentModel;

/// <summary>
/// クエストマスタ
/// </summary>
[Description("SkillFxMB")]
public class SkillFxMB : MasterBookBase
{
    /// <summary>
    /// 説明文
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// アニメーション時間再生倍率
    /// </summary>
    public float animationTimeScale { get; set; }

    /// <summary>
    /// スキル演出の位置タイプ
    /// </summary>
    public SkillFxPositionType skillFxPositionType { get; set; }

    /// <summary>
    /// x方向のタイル数
    /// </summary>
    public int numTilesX { get; set; }

    /// <summary>
    /// y方向のタイル数
    /// </summary>
    public int numTilesY { get; set; }

    /// <summary>
    /// x方向のオフセット
    /// </summary>
    public float offsetX { get; set; }

    /// <summary>
    /// y方向のオフセット
    /// </summary>
    public float offsetY { get; set; }

    /// <summary>
    /// サイズのスケール
    /// </summary>
    public float sizeScale { get; set; }
}
