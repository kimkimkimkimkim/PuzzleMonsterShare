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
        /// 行動したときのエネルギー上昇量
        /// </summary>
        public static int ENERGY_RISE_VALUE_ON_ACT = 50;

        /// <summary>
        /// ダメージを受けたときのエネルギー上昇量
        /// </summary>
        public static int ENERGY_RISE_VALUE_ON_TAKE_DAMAGE = 25;

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
