﻿using System.ComponentModel;

/// <summary>
/// モンスター経験値テーブルマスタ
/// </summary>
[Description("MonsterLevelUpTableMB")]
public class MonsterLevelUpTableMB : MasterBookBase
{
    /// <summary>
    /// 目標レベル
    /// </summary>
    public int level { get; set; }

    /// <summary>
    /// １つ前のレベルから目標レベルになるために必要な経験値量
    /// </summary>
    public int requiredExp { get; set; }
}
