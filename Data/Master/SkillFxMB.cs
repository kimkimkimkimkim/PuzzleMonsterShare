using System.ComponentModel;

/// <summary>
/// クエストマスタ
/// </summary>
[Description("SkillFxMB")]
public class SkillFxMB : MasterBookBase
{
    /// <summary>
    /// 名前
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 説明文
    /// </summary>
    public string description { get; set; }
}
