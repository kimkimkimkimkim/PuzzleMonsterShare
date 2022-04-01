using System;
using System.Collections.Generic;

public class ConstManager
{
    public class System
    {
        /// <summary>
        /// ユーザー名の最小文字数
        /// </summary>
        public static int userNameMinWordCount = 3;

        /// <summary>
        /// ユーザー名の最大文字数
        /// </summary>
        public static int userNameMaxWordCount = 10;

        /// <summary>
        /// 一日の開始時（24時間表記での時）
        /// </summary>
        public static int START_DAY_HOUR = 4;

        /// <summary>
        /// 週の開始曜日
        /// </summary>
        public static DayOfWeek START_WEEK_DAY_OF_WEEK = DayOfWeek.Monday;

        /// <summary>
        /// 月の開始日
        /// </summary>
        public static int START_MONTH_DATE = 1;
    }

    public class User
    {
        /// <summary>
        /// 1スタミナ溜まるのに必要な時間[ms]
        /// </summary>
        public static int millSecondsPerStamina = 180000;
    }

    public class Monster
    {
        /// <summary>
        /// 全モンスターの中での最大ステータス値
        /// ゲージの最大値として使用する
        /// </summary>
        public static int MAX_STATUS_VALUE = 5000;

        /// <summary>
        /// 最大レベル
        /// </summary>
        public static int MAX_LEVEL = 100;
        
        /// <summary>
        /// 対象モンスターを1体消費した際のラック上昇量
        /// </summary>
        public static int LUCK_UP_NUM(bool isGachaMonster) => isGachaMonster ? 5 : 1;
        
        /// <summary>
        /// 最大ラック
        /// </summary>
        public static int MAX_LUCK = 100;
    }

    public class Battle
    {
        /// <summary>
        /// 最大パーティーメンバー数
        /// </summary>
        public static int MAX_PARTY_MEMBER_NUM = 5;

        /// <summary>
        /// 最大パーティ数
        /// </summary>
        public static int MAX_PARTY_NUM = 5;

        /// <summary>
        /// 盤面の横のピース数
        /// </summary>
        public static int BOARD_WIDTH = 8;

        /// <summary>
        /// 盤面の縦のピース数
        /// </summary>
        public static int BOARD_HEIGHT = 8;

        /// <summary>
        /// エネルギーの最大値
        /// </summary>
        public static int MAX_ENERGY_VALUE = 100;

        /// <summary>
        /// エネルギーの初期値
        /// </summary>
        public static int INITIAL_ENERGY_VALUE = 50;

        /// <summary>
        /// 行動したときのエネルギー上昇量
        /// </summary>
        public static int ENERGY_RISE_VALUE_ON_ACT = 50;

        /// <summary>
        /// ダメージを受けたときのエネルギー上昇量
        /// </summary>
        public static int ENERGY_RISE_VALUE_ON_TAKE_DAMAGE = 10;

        /// <summary>
        /// 前衛のインデックスリスト
        /// </summary>
        public static List<int> FRONT_INDEX_LIST = new List<int>() { 0, 1 };

        /// <summary>
        /// 後衛のインデックスリスト
        /// </summary>
        public static List<int> BACK_INDEX_LIST = new List<int>() { 2, 3, 4 };

    }
}
