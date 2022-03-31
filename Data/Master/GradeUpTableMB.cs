using System.Collections.Generic;
using System.ComponentModel;
using PM.Enum.Monster;

/// <summary>
/// グレードアップテーブルマスタ
/// </summary>
[Description("GradeUpTableMB")]
public class GradeUpTableMB : MasterBookBase
{
    /// <summary>
    /// モンスターの属性
    /// </summary>
    public MonsterAttribute monsterAttribute { get; set; }
    
    /// <summary>
    /// 対象のグレード
    /// </summary>
    public int targetGrade { get; set; }
    
    /// <summary>
    /// 対象のグレードに覚醒するのに必要なアイテムリスト
    /// </summary>
    public List<ItemMI> requiredItemList { get; set; }
}
