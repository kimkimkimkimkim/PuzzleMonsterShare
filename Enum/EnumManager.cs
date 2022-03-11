﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    namespace Enum
    {
        namespace Battle
        {
            /// <summary>
            /// ドロップタイプ
            /// </summary>
            public enum DropType
            {
                /// <summary>
                /// 通常
                /// </summary>
                Normal = 0,

                /// <summary>
                /// お邪魔
                /// </summary>
                Disturb = 1,
            }

            /// <summary>
            /// コマンドの方向
            /// </summary>
            public enum Direction
            {
                Up,
                Down,
                UpperRight,
                LowerRight,
                UpperLeft,
                LowerLeft,
            }

            /// <summary>
            /// 勝敗判定
            /// </summary>
            public enum WinOrLose
            {
                None,
                Win,
                Lose,
                Continue,
            }

            /// <summary>
            /// ピースの色
            /// </summary>
            public enum PieceColor
            {
                TransParent,
                LightBrown,
                DarkBrown,
            }

            /// <summary>
            /// ピースのステータス
            /// </summary>
            public enum PieceStatus
            {
                None,
                Free,
                Normal,
            }
            
            /// <summary>
            /// ログタイプ
            /// </summary>
            public enum BattleLogType
            {
                /// <summary>
                /// ログ確認用
                /// </summary>
                None,

                /// <summary>
                /// バトル開始ログ
                /// </summary>
                StartBattle,

                /// <summary>
                /// ウェーブ進行ログ
                /// </summary>
                MoveWave,

                /// <summary>
                /// ターン進行ログ
                /// </summary>
                MoveTurn,

                /// <summary>
                /// アクション開始ログ
                /// </summary>
                StartAction,
                
                /// <summary>
                /// アクション開始アニメーションログ
                /// </summary>
                StartActionAnimation,
                
                /// <summary>
                /// アクション失敗ログ
                /// </summary>
                ActionFailed,

                /// <summary>
                /// スキル効果発動ログ
                /// </summary>
                StartSkillEffect,

                /// <summary>
                /// ダメージログ
                /// </summary>
                TakeDamage,
                
                /// <summary>
                /// 回復ログ
                /// </summary>
                TakeHeal,

                /// <summary>
                /// 状態異常付与ログ
                /// </summary>
                TakeBattleConditionAdd,

                /// <summary>
                /// 状態異常解除ログ
                /// </summary>
                TakeBattleConditionRemove,
                
                /// <summary>
                /// 蘇生ログ
                /// </summary>
                TakeRevive,

                /// <summary>
                /// 死亡ログ
                /// </summary>
                Die,
                
                /// <summary>
                /// 状態異常ターン進行ログ
                /// </summary>
                ProgressBattleConditionTurn,

                /// <summary>
                /// アクション終了ログ
                /// </summary>
                EndAction,

                /// <summary>
                /// バトル結果ログ
                /// </summary>
                Result,
            }
            
            /// <summary>
            /// 状態異常タイプ
            /// </summary>
            public enum BattleConditionType
            {
                None = 0,

                /// <summary>
                /// ステータス上昇
                /// </summary>
                StatusUp = 1,

                /// <summary>
                /// ステータス下降
                /// </summary>
                StatusDown = 2,

                /// <summary>
                /// 通常スキル、アルティメットスキル、パッシブスキル使用不可
                /// </summary>
                NormalAndUltimateAndPassiveSkillUnavailable = 3,

                /// <summary>
                /// 通常スキル使用不可
                /// </summary>
                NormalSkillUnavailable = 4,

                /// <summary>
                /// アルティメットスキル使用不可
                /// </summary>
                UltimateSkillUnavailable = 5,

                /// <summary>
                /// パッシブスキル使用不可
                /// </summary>
                PassiveSkillUnavailable = 6,

                /// <summary>
                /// シールド
                /// </summary>
                Shield = 7,

                /// <summary>
                /// 状態異常特攻
                /// </summary>
                BattleConditionKiller = 8,

                /// <summary>
                /// 特定バフタイプの個数特攻
                /// </summary>
                BuffTypeNumKiller = 9,

                /// <summary>
                /// 属性特攻
                /// </summary>
                MonsterAttributeKiller = 10,
                
                /// <summary>
                /// 状態異常耐性
                /// </summary>
                BattleConditionResist = 11,
                
                /// <summary>
                /// 指定バフタイプの耐性
                /// </summary>
                BuffTypeResist = 12,

                /// <summary>
                /// マーク
                /// </summary>
                Mark = 13,

                /// <summary>
                /// アクション
                /// </summary>
                Action = 14,
            }

            /// <summary>
            /// スキル対象タイプ
            /// </summary>
            public enum SkillTargetType
            {
                None = 0,

                /// <summary>
                /// 自分
                /// </summary>
                Myself = 1,

                /// <summary>
                /// 味方全体
                /// </summary>
                AllyAll = 2,

                /// <summary>
                /// 敵全体
                /// </summary>
                EnemyAll = 3,

                /// <summary>
                /// 味方全体の中からランダムで1体
                /// </summary>
                AllyAllRandom1 = 4,

                /// <summary>
                /// 味方全体の中からランダムで2体
                /// </summary>
                AllyAllRandom2 = 5,

                /// <summary>
                /// 味方全体の中からランダムで3体
                /// </summary>
                AllyAllRandom3 = 6,

                /// <summary>
                /// 味方全体の中からランダムで4体
                /// </summary>
                AllyAllRandom4 = 7,

                /// <summary>
                /// 味方全体の中からランダムで5体
                /// </summary>
                AllyAllRandom5 = 8,

                /// <summary>
                /// 敵全体の中からランダムで1体
                /// </summary>
                EnemyAllRandom1 = 9,

                /// <summary>
                /// 敵全体の中からランダムで2体
                /// </summary>
                EnemyAllRandom2 = 10,

                /// <summary>
                /// 敵全体の中からランダムで3体
                /// </summary>
                EnemyAllRandom3 = 11,

                /// <summary>
                /// 敵全体の中からランダムで4体
                /// </summary>
                EnemyAllRandom4 = 12,

                /// <summary>
                /// 敵全体の中からランダムで5体
                /// </summary>
                EnemyAllRandom5 = 13,

                /// <summary>
                /// 攻撃したモンスター
                /// </summary>
                DoAttack = 14,

                /// <summary>
                /// 攻撃されたモンスター
                /// </summary>
                BeAttacked = 15,

                /// <summary>
                /// 味方前衛全体
                /// </summary>
                AllyFrontAll = 16,

                /// <summary>
                /// 味方後衛全体
                /// </summary>
                AllyBackAll = 17,

                /// <summary>
                /// 敵前衛全体
                /// </summary>
                EnemyFrontAll = 18,

                /// <summary>
                /// 敵後衛全体
                /// </summary>
                EnemyBackAll = 19,

                /// <summary>
                /// 一番前の味方
                /// </summary>
                AllyMostFront = 20,

                /// <summary>
                /// 一番前の敵
                /// </summary>
                EnemyMostFront = 21,

                /// <summary>
                /// 味方全体の中からHPが低い順に1体
                /// </summary>
                AllyAllHPLowest1 = 22,

                /// <summary>
                /// 味方全体の中からHPが低い順に2体
                /// </summary>
                AllyAllHPLowest2 = 23,

                /// <summary>
                /// 味方全体の中からHPが低い順に3体
                /// </summary>
                AllyAllHPLowest3 = 24,

                /// <summary>
                /// 味方全体の中からHPが低い順に4体
                /// </summary>
                AllyAllHPLowest4 = 25,

                /// <summary>
                /// 敵全体の中からHPが低い順に1体
                /// </summary>
                EnemyAllHPLowest1 = 26,

                /// <summary>
                /// 敵全体の中からHPが低い順に2体
                /// </summary>
                EnemyAllHPLowest2 = 27,

                /// <summary>
                /// 敵全体の中からHPが低い順に3体
                /// </summary>
                EnemyAllHPLowest3 = 28,

                /// <summary>
                /// 敵全体の中からHPが低い順に4体
                /// </summary>
                EnemyAllHPLowest4 = 29,

                /// <summary>
                /// すでに対象にしたモンスター
                /// リストの最初の要素の対象
                /// </summary>
                Target = 30,
            }

            /// <summary>
            /// 効果量ターゲットタイプ
            /// </summary>
            public enum ValueTargetType
            {
                None = 0,

                /// <summary>
                /// 自身の現在の体力
                /// </summary>
                MyCurrentHP = 1,

                /// <summary>
                /// 自身の現在の攻撃力
                /// </summary>
                MyCurrentAttack = 2,

                /// <summary>
                /// 自身の現在の防御力
                /// </summary>
                MyCurrentDefense = 3,

                /// <summary>
                /// 自身の現在の回復力
                /// </summary>
                MyCurrentHeal = 4,

                /// <summary>
                /// 自身の現在のスピード
                /// </summary>
                MyCurrentSpeed = 5,

                /// <summary>
                /// 自身の最大の体力
                /// </summary>
                MyMaxHp = 6,

                /// <summary>
                /// 対象の現在の体力
                /// </summary>
                TargetCurrentHP = 7,

                /// <summary>
                /// 対象の現在の攻撃力
                /// </summary>
                TargetCurrentAttack = 8,

                /// <summary>
                /// 対象の現在の防御力
                /// </summary>
                TargetCurrentDefense = 9,

                /// <summary>
                /// 対象の現在の回復力
                /// </summary>
                TargetCurrentHeal = 10,

                /// <summary>
                /// 対象の現在のスピード
                /// </summary>
                TargetCurrentSpeed = 11,

                /// <summary>
                /// 対象の最大の体力
                /// </summary>
                TargetMaxHp = 12,
            }

            /// <summary>
            /// スキルトリガータイプ
            /// 時＋主語＋動作＋前後
            /// </summary>
            public enum SkillTriggerType
            {
                None = 0,

                /// <summary>
                /// 毎アクション毎
                /// </summary>
                EveryTimeEnd = 1,

                /// <summary>
                /// バトル開始時
                /// </summary>
                OnBattleStart = 2,

                /// <summary>
                /// 自分のアクション終了時
                /// </summary>
                OnMeActionEnd = 3,

                /// <summary>
                /// 自分の通常攻撃終了時
                /// </summary>
                OnMeNormalSkillEnd = 4,

                /// <summary>
                /// 自分のウルト終了時
                /// </summary>
                OnMeUltimateSkillEnd = 5,

                /// <summary>
                /// 自分がダメージを受けたとき
                /// </summary>
                OnMeTakeDamageEnd = 6,

                /// <summary>
                /// 自分が倒れたとき
                /// </summary>
                OnMeDeadEnd = 7,

                /// <summary>
                /// ウェーブ開始時
                /// </summary>
                OnWaveStart = 8,

                /// <summary>
                /// ターン開始時
                /// </summary>
                OnTurnStart = 9,

                /// <summary>
                /// 自分のアクション開始時
                /// </summary>
                OnMeActionStart = 10,

                /// <summary>
                /// 自分がアクション処理される前
                /// </summary>
                OnMeTakeActionBefore = 11,

                /// <summary>
                /// 自分がアクション処理された後
                /// </summary>
                OnMeTakeActionAfter = 12,

                /// <summary>
                /// ターン終了時
                /// </summary>
                OnTurnEnd = 13,

                /// <summary>
                /// ウェーブ終了時
                /// </summary>
                OnWaveEnd = 14,
            }

            public enum BattleConditionTriggerType
            {
                None = 0,

                /// <summary>
                /// 毎アクション終了時
                /// </summary>
                EveryTimeEnd = 1,

                /// <summary>
                /// バトル開始時
                /// </summary>
                OnBattleStart = 2,

                /// <summary>
                /// 自分のアクション終了時
                /// </summary>
                OnMeActionEnd = 3,

                /// <summary>
                /// 自分の通常攻撃終了時
                /// </summary>
                OnMeNormalSkillEnd = 4,

                /// <summary>
                /// 自分のウルト終了時
                /// </summary>
                OnMeUltimateSkillEnd = 5,

                /// <summary>
                /// 自分がダメージを受けたとき
                /// </summary>
                OnMeTakeDamageEnd = 6,

                /// <summary>
                /// 自分が倒れたとき
                /// </summary>
                OnMeDeadEnd = 7,

                /// <summary>
                /// ウェーブ開始時
                /// </summary>
                OnWaveStart = 8,

                /// <summary>
                /// ターン開始時
                /// </summary>
                OnTurnStart = 9,

                /// <summary>
                /// 自分のアクション開始時
                /// </summary>
                OnMeActionStart = 10,

                /// <summary>
                /// 自分がアクション処理される前
                /// </summary>
                OnMeTakeActionBefore = 11,

                /// <summary>
                /// 自分がアクション処理された後
                /// </summary>
                OnMeTakeActionAfter = 12,

                /// <summary>
                /// ターン終了時
                /// </summary>
                OnTurnEnd = 13,

                /// <summary>
                /// ウェーブ終了時
                /// </summary>
                OnWaveEnd = 14,

                /// <summary>
                /// 解除された時
                /// </summary>
                OnRemoved = 15,

                /// <summary>
                /// 常時
                /// </summary>
                Always = 16,
            }

            /// <summary>
            /// 状態異常のバフタイプ
            /// </summary>
            public enum BuffType
            {
                None = 0,

                /// <summary>
                /// 強化効果
                /// </summary>
                Buff = 1,

                /// <summary>
                /// 弱体効果
                /// </summary>
                Debuff = 2,
            }

            /// <summary>
            /// 発動条件タイプ
            /// above: より大きい, upper: 以上
            /// under: 未満, lower: 以下
            /// </summary>
            public enum ActivateConditionType
            {
                None = 0,

                /// <summary>
                /// HPが50%未満の時
                /// </summary>
                Under50PercentMyHP = 1,

                /// <summary>
                /// 生きている時
                /// </summary>
                Alive = 2,

                /// <summary>
                /// 戦闘不能の時
                /// </summary>
                Dead = 3,
            }

            /// <summary>
            /// スキルタイプ
            /// </summary>
            public enum SkillType
            {
                None = 0,

                /// <summary>
                /// 攻撃
                /// </summary>
                Damage = 1,

                /// <summary>
                /// 回復
                /// </summary>
                Heal = 2,

                /// <summary>
                /// 状態異常付与
                /// </summary>
                ConditionAdd = 3,

                /// <summary>
                /// 状態異常解除
                /// </summary>
                ConditionRemove = 4,

                /// <summary>
                /// 蘇生
                /// </summary>
                Revive = 5,
            }

            /// <summary>
            /// アクションタイプ
            /// </summary>
            public enum BattleActionType
            {
                None,

                /// <summary>
                /// 通常攻撃
                /// </summary>
                NormalSkill,

                /// <summary>
                /// 必殺技
                /// </summary>
                UltimateSkill,

                /// <summary>
                /// パッシブスキル
                /// </summary>
                PassiveSkill,

                /// <summary>
                /// 状態異常効果
                /// </summary>
                BattleCondition,
            }

            /// <summary>
            /// バトル用のモンスターステータスタイプ
            /// </summary>
            public enum BattleMonsterStatusType
            {
                None = 0,
                Hp = 1,
                Attack = 2,
                Defense = 3,
                Heal = 4,
                Speed = 5,
                Sheild = 6,
                UltimateSkillDamageRate = 7,
                BlockRate = 8,
                CriticalRate = 9,
                CriticalDamage = 10,
                BuffResistRate = 11,
                DebuffResistRate = 12,
                DamageResistRate = 13,
                LuckDamageRate = 14,
                HolyDamageRate = 15,
                EnergyUpRate = 16,
                HealedRate = 17,
            }
        }

        namespace UI
        {
            /// <summary>
            /// ダイアログのレスポンス種類
            /// </summary>
            public enum DialogResponseType
            {
                None,
                Yes,
                No,
            }

            /// <summary>
            /// コモンダイアログタイプ
            /// </summary>
            public enum CommonDialogType
            {
                NoAndYes,
                YesOnly,
            }

            /// <summary>
            /// フッタータイプ
            /// </summary>
            [Serializable]
            public enum FooterType
            {
                Home = 0,
                Monster = 1,
                Gacha = 2,
                Shop = 3,
            }

            /// <summary>
            /// アイコン画像タイプ
            /// </summary>
            public enum IconImageType
            {
                /// <summary>
                /// 初期値
                /// </summary>
                None = 0,

                /// <summary>
                /// 仮想通貨
                /// </summary>
                VirtualCurrency = 1,

                /// <summary>
                /// モンスター
                /// </summary>
                Monster = 2,

                /// <summary>
                /// 資産
                /// </summary>
                Property = 3,

                /// <summary>
                /// モンスター属性
                /// </summary>
                MonsterAttribute = 4,

                /// <summary>
                /// 状態異常
                /// </summary>
                BattleCondition = 5,
            }
        }

        namespace Item
        {
            /// <summary>
            /// アイテムタイプ
            /// インベントリアイテムのクラスとも対応
            /// </summary>
            public enum ItemType
            {
                /// <summary>
                /// 初期値
                /// </summary>
                None = 0,

                /// <summary>
                /// 仮想通貨
                /// </summary>
                VirtualCurrency = 1,

                /// <summary>
                /// モンスター
                /// </summary>
                Monster = 2,

                /// <summary>
                /// 資産
                /// </summary>
                Property = 3,

                /// <summary>
                /// ドロップテーブル
                /// </summary>
                DropTable = 4,

                /// <summary>
                /// バンドル
                /// </summary>
                Bundle = 5,

                /// <summary>
                /// コンテナ
                /// </summary>
                Container = 6,
            }

            /// <summary>
            /// 仮想通貨タイプ
            /// VirtualCurrencyMBのIDと対応
            /// </summary>
            public enum VirtualCurrencyType
            {
                /// <summary>
                /// オーブ
                /// </summary>
                OB = 1,

                /// <summary>
                /// コイン
                /// </summary>
                CN = 2,

                /// <summary>
                /// プレイヤー経験値
                /// </summary>
                PE = 3,

                /// <summary>
                /// モンスター経験値
                /// </summary>
                ME = 4,
            }

            public static class VirtualCurrencyTypeExtends
            {
                public static string Name(this VirtualCurrencyType type)
                {
                    switch (type) {
                        case VirtualCurrencyType.OB:
                            return "オーブ";
                        case VirtualCurrencyType.CN:
                            return "コイン";
                        case VirtualCurrencyType.PE:
                            return "プレイヤー経験値";
                        case VirtualCurrencyType.ME:
                            return "モンスター経験値";
                        default:
                            return "";
                    }
                }
            }

            /// <summary>
            /// 資産タイプ
            /// PropertyMBのIDと対応
            /// </summary>
            public enum PropertyType
            {
            }

            /// <summary>
            /// アイコン色タイプ
            /// </summary>
            public enum IconColorType
            {
                None = 0,
                Red = 1,
                Blue = 2,
                Green = 3,
                Yellow = 4,
                Purple = 5,
            }

            /// <summary>
            /// テキスト色タイプ
            /// </summary>
            public enum TextColorType
            {
                White = 0,
                Focus = 1,
            }

            /// <summary>
            /// テキストカラー拡張
            /// </summary>
            public static class TextColorTypeExtends
            {
                private static readonly Dictionary<TextColorType, string> ColorDictionary = new Dictionary<TextColorType, string>() {
                    { TextColorType.White, "#FFFFFF" },
                    { TextColorType.Focus, "#F6E19C" },
                };

                /// <summary>
                /// テキストカラーを取得
                /// </summary>
                public static string Color(this TextColorType textColorType)
                {
                    return ColorDictionary.ContainsKey(textColorType) ? ColorDictionary[textColorType] : "#FFFFFF";
                }
            }
        }

        namespace Gacha
        {
            /// <summary>
            /// ガチャのドロップテーブルタイプ
            /// </summary>
            public enum DropTableType
            {
                /// <summary>
                /// レア召喚（シングル）
                /// </summary>
                NormalGachaSingle = 1,
            }

            /// <summary>
            /// どのようなモンスターが排出するガチャなのかを示す値
            /// どのタイプのガチャから排出するモンスターなのかを示す値
            /// </summary>
            public enum GachaBoxType
            {
                Normal = 1,
            }

            public enum GachaExecuteType
            {
                /// <summary>
                /// 通常単発
                /// </summary>
                One = 1,

                /// <summary>
                /// 通常十連
                /// </summary>
                Ten = 2,
            }

            /// <summary>
            /// ガチャ実行タイプ拡張
            /// </summary>
            public static class GachaExecuteTypeExtends
            {
                /// <summary>
                /// ガチャ実行タイプごとのガチャ回数を取得
                /// </summary>
                public static int Num(this GachaExecuteType type)
                {
                    switch (type) {
                        case GachaExecuteType.One:
                            return 1;
                        case GachaExecuteType.Ten:
                            return 10;
                        default:
                            return 1;
                    }
                }
            }
        }

        namespace Data
        {
            /// <summary>
            /// ユーザーデータをPlayFabに保存する時のKey名
            /// UserDataInfoのパラメータ名と同じにする必要がある
            /// </summary>
            public enum UserDataKey
            {
                userMonsterList,
                userPropertyList,
                userMonsterPartyList,
                lastLoginDateTime,
                lastCalculatedStaminaDateTime,
                stamina,
                totalPlayerExp,
                rank,
                userBattleList,
                userMissionList,
                userPresentList,
            }
        }

        namespace Quest
        {
            /// <summary>
            /// クエストタイプ
            /// </summary>
            public enum QuestType
            {
                Normal = 1,
                Event = 2,
            }
        }

        namespace Mission
        {
            /// <summary>
            /// ミッションタイプ
            /// </summary>
            public enum MissionType
            {
                Main = 1,
                Daily = 2,
                Weekly = 3,
                Monthly = 4,
                Event = 5,
            }
        }

        namespace Monster
        {
            /// <summary>
            /// 属性
            /// </summary>
            public enum MonsterAttribute
            {
                Red = 1,
                Blue = 2,
                Green = 3,
                Yellow = 4,
                Purple = 5,
            }

            public static class MonsterAttributeExtends
            {
                public static Color Color(this MonsterAttribute attribute)
                {
                    switch (attribute)
                    {
                        case MonsterAttribute.Red:
                            return new Color(0.1529412f, 0.03921569f, 0.03137255f);
                        case MonsterAttribute.Blue:
                            return new Color(0.007843138f, 0.07450981f, 0.2039216f);
                        case MonsterAttribute.Green:
                            return new Color(0.07843138f, 0.1803922f, 0.1333333f);
                        case MonsterAttribute.Yellow:
                            return new Color(0.9647059f, 0.8823529f, 0.6117647f);
                        case MonsterAttribute.Purple:
                            return new Color(0.1294118f, 0.05098039f, 0.2039216f);
                        default:
                            return new Color(0, 0, 0);
                    }
                }
            }
        }
        
        namespace Condition
        {
            /// <summary>
            /// 条件タイプ
            /// </summary>
            public enum ConditionType
            {
                /// <summary>
                /// 指定したクエストIDをクリアしているか
                /// </summary>
                UpperQuestId = 1,

                /// <summary>
                /// 指定したクエストIDまでをクリアしているか
                /// </summary>
                LowerQuestId = 2,

                /// <summary>
                /// 指定した日時を過ぎているか
                /// String（XXXX-XX-XX XX:XX:XX）
                /// </summary>
                UpperDate = 3,

                /// <summary>
                /// 指定した日時を過ぎていないか
                /// String（XXXX-XX-XX XX:XX:XX）
                /// </summary>
                LowerDate = 4,

                /// <summary>
                /// 指定したミッションをクリアしているか
                /// </summary>
                UpperMissionId = 5,

                /// <summary>
                /// 指定したミッションまでクリアしているか
                /// </summary>
                LowerMissionId = 6,

                /// <summary>
                /// 指定したプレイヤーランク以上か
                /// </summary>
                UpperPlayerRank = 7,

                /// <summary>
                /// 指定したプレイヤーランク以下か
                /// </summary>
                LowerPlayerRank = 8,

                /// <summary>
                /// デイリーミッションをすべてクリアしているか
                /// </summary>
                AllClearDailyMission = 9,

                /// <summary>
                /// 通算ログイン日数が指定日数以上か
                /// </summary>
                UpperTotalLoginDate = 10,

                /// <summary>
                /// 通算ログイン日数が指定日数以下か
                /// </summary>
                LowerTotalLoginDate = 11,

                /// <summary>
                /// 本日ログインしたか
                /// </summary>
                LoginToday = 12,

                /// <summary>
                /// 本日クエストを一つでもクリアしたか
                /// </summary>
                ClearQuestToday = 13,
            }
        }
    }
}
