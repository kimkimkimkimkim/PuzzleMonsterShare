﻿using System;
using System.Collections.Generic;

namespace PM {
    namespace Enum {
        namespace Battle {
            /// <summary>
            /// ドロップタイプ
            /// </summary>
            public enum DropType {
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
            public enum Direction {
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
            public enum WinOrLose {
                None,
                Win,
                Lose,
                Continue,
                Interruption,
            }

            /// <summary>
            /// ピースの色
            /// </summary>
            public enum PieceColor {
                TransParent,
                LightBrown,
                DarkBrown,
            }

            /// <summary>
            /// ピースのステータス
            /// </summary>
            public enum PieceStatus {
                None,
                Free,
                Normal,
            }

            /// <summary>
            /// ログタイプ
            /// </summary>
            public enum BattleLogType {
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
                /// ターンアクション開始ログ
                /// </summary>
                StartTurnAction,

                /// <summary>
                /// ターンアクション終了ログ
                /// </summary>
                EndTurnAction,

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
                /// 発動確率によるスキル効果未発動ログ
                /// </summary>
                SkillEffectFailedOfProbabilityMiss,

                /// <summary>
                /// スキル対象決定ログ
                /// </summary>
                SetSkillTarget,

                /// <summary>
                /// スキル効果発動ログ
                /// </summary>
                StartSkillEffect,

                /// <summary>
                /// トリガースキルログ
                /// </summary>
                TriggerSkill,

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
                /// 状態異常解除前ログ
                /// </summary>
                TakeBattleConditionRemoveBefore,

                /// <summary>
                /// 状態異常解除後ログ
                /// </summary>
                TakeBattleConditionRemoveAfter,

                /// <summary>
                /// 蘇生ログ
                /// </summary>
                TakeRevive,

                /// <summary>
                /// ステータス変化ログ
                /// </summary>
                TakeStatusChange,

                /// <summary>
                /// エネルギー上昇ログ
                /// </summary>
                EnergyUp,

                /// <summary>
                /// エネルギー減少ログ
                /// </summary>
                EnergyDown,

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
                /// ターン終了ログ
                /// </summary>
                EndTurn,

                /// <summary>
                /// ウェーブ終了ログ
                /// </summary>
                EndWave,

                /// <summary>
                /// バトル結果ログ
                /// </summary>
                Result,
            }

            /// <summary>
            /// 状態異常タイプ
            /// </summary>
            public enum BattleConditionType {
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
            public enum SkillTargetType {
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
                /// 攻撃してきたモンスター
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
                /// リストの直前の要素の効果の対象
                /// </summary>
                JustBeforeElementTarget = 30,

                /// <summary>
                /// 味方前衛全体の中からランダムで1体
                /// </summary>
                AllyFrontRandom1 = 31,

                /// <summary>
                /// 味方前衛全体の中からランダムで2体
                /// </summary>
                AllyFrontRandom2 = 32,

                /// <summary>
                /// 味方後衛全体の中からランダムで1体
                /// </summary>
                AllyBackRandom1 = 33,

                /// <summary>
                /// 味方後衛全体の中からランダムで2体
                /// </summary>
                AllyBackRandom2 = 34,

                /// <summary>
                /// 味方後衛全体の中からランダムで3体
                /// </summary>
                AllyBackRandom3 = 35,

                /// <summary>
                /// 敵前衛全体の中からランダムで1体
                /// </summary>
                EnemyFrontRandom1 = 36,

                /// <summary>
                /// 敵前衛全体の中からランダムで2体
                /// </summary>
                EnemyFrontRandom2 = 37,

                /// <summary>
                /// 敵後衛全体の中からランダムで1体
                /// </summary>
                EnemyBackRandom1 = 38,

                /// <summary>
                /// 敵後衛全体の中からランダムで2体
                /// </summary>
                EnemyBackRandom2 = 39,

                /// <summary>
                /// 敵後衛全体の中からランダムで3体
                /// </summary>
                EnemyBackRandom3 = 40,

                /// <summary>
                /// すでに対象にしたモンスター
                /// リストの一番最初の要素の効果の対象
                /// </summary>
                FirstElementTarget = 41,

                /// <summary>
                /// すでに対象にしたモンスター
                /// リストの直前の要素の効果の対象
                /// その要素の効果が成功した時のみ
                /// </summary>
                JustBeforeElementTargetOnlySuccess = 42,
            }

            /// <summary>
            /// 効果量ターゲットタイプ
            /// </summary>
            public enum ValueTargetType {
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

                /// <summary>
                /// 一番最初の要素で自身が与えたダメージ
                /// </summary>
                FirstElementDamage = 13,

                /// <summary>
                /// 直前の要素で自身が与えたダメージ
                /// </summary>
                JustBeforeElementDamage = 14,

                /// <summary>
                /// 直前の要素で解除した状態異常の残りダメージ
                /// </summary>
                JustBeforeElementRemoveBattleConditionRemainDamage = 15,

                /// <summary>
                /// この要素より前のすべての要素で解除した状態異常の残りダメージ
                /// </summary>
                AllBeforeElementRemoveBattleConditionRemainDamage = 16,

                /// <summary>
                /// 直前に受けたダメージ
                /// トリガーの対象スキルの被ダメージ量
                /// </summary>
                JustBeforeTakeDamage = 17,
            }

            /// <summary>
            /// スキルトリガータイプ
            /// 時＋主語＋動作＋前後
            /// </summary>
            public enum SkillTriggerType {
                /// <summary>
                /// 常時
                /// </summary>
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
                /// 状態異常ダメージも含む
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
                /// 自身以外から自分がアクション処理される前
                /// </summary>
                OnMeTakeActionBefore = 11,

                /// <summary>
                /// 自身以外から自分がアクション処理された後
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
                /// 自身が自身以外にダメージを与えたとき
                /// </summary>
                OnMeExecuteDamageAfter = 15,

                /// <summary>
                /// 自身が自身以外にクリティカルを発動した後
                /// </summary>
                OnMeExecuteCriticcalAfter = 16,

                /// <summary>
                /// 味方が戦闘不能になった時
                /// </summary>
                OnAllyDead = 17,

                /// <summary>
                /// 敵が戦闘不能になった時
                /// </summary>
                OnEnemyDead = 18,

                /// <summary>
                /// 自身に特定状態異常が付与された時
                /// </summary>
                OnMeBeAddedBattleCondition = 19,

                /// <summary>
                /// 味方に特定状態異常が付与された時
                /// </summary>
                OnAllyBeAddedBattleCondition = 20,

                /// <summary>
                /// 敵に特定状態異常が付与された時
                /// </summary>
                OnEnemyBeAddedBattleCondition = 21,

                /// <summary>
                /// 自身が攻撃をブロックされた時
                /// </summary>
                OnMeBeBlocked = 22,

                /// <summary>
                /// 自身以外から自身が攻撃をブロックした時
                /// </summary>
                OnMeBlocked = 23,

                /// <summary>
                /// 自身が通常攻撃またはウルトを発動した時
                /// </summary>
                OnMeExecuteNormalOrUltimateSkill = 24,

                /// <summary>
                /// 自身以外から自身が通常攻撃またはウルトを受けた時
                /// actionTypeがNormal,UltimateでskillTypeがAttack,Damageの時
                /// </summary>
                OnMeBeExecutedNormalOrUltimateSkill = 25,

                /// <summary>
                /// 味方がブロックした時
                /// </summary>
                OnAllyBlocked = 26,

                /// <summary>
                /// 敵がブロックした時
                /// </summary>
                OnEnemyBlocked = 27,

                /// <summary>
                /// 自身が通常攻撃を発動した時
                /// </summary>
                OnMeExecuteNormalSkill = 28,

                /// <summary>
                /// 自身以外から自身が通常攻撃を受けたとき
                /// </summary>
                OnMeBeExecutedNormalSkill = 29,

                /// <summary>
                /// 自身が攻撃したとき
                /// SkillType.Attackのみ
                /// </summary>
                OnMeAttacked = 30,

                /// <summary>
                /// 自身以外から自身が攻撃されたとき
                /// SkillType.Attackのみ
                /// </summary>
                OnMeBeAttacked = 31,

                /// <summary>
                /// 自身以外から自身がクリティカルを受けたとき
                /// </summary>
                OnMeBeAttackedCritical = 32,

                /// <summary>
                /// 自身が継続ダメージを受けたとき
                /// </summary>
                OnMeBeAttackedDot = 33,

                /// <summary>
                /// 自身が特定状態異常の相手に攻撃したとき
                /// </summary>
                OnMeAttackBattleCondition = 34,

                /// <summary>
                /// 自身以外から自身が特定状態異常の相手に攻撃されたとき
                /// </summary>
                OnMeBeAttackedBattleCondition = 35,

                /// <summary>
                /// 自身が自身より特定ステータスの低い相手に攻撃したとき
                /// </summary>
                OnMeAttackLowerStatus = 36,

                /// <summary>
                /// 自身が自身より特定ステータスの高い相手に攻撃したとき
                /// </summary>
                OnMeAttackUpperStatus = 37,

                /// <summary>
                /// 自身以外からの自身より特定ステータスの低い相手に攻撃されたとき
                /// </summary>
                OnMeBeAttackedLowerStatus = 38,

                /// <summary>
                /// 自身が自身より特定ステータスの高い相手に攻撃されたとき
                /// </summary>
                OnMeBeAttackedUpperStatus = 39,

                /// <summary>
                /// 味方がウルトを使ったとき
                /// skillEffectIndex=0発動直後
                /// </summary>
                OnAllyUltimateSkill = 40,

                /// <summary>
                /// 自身が指定回数ブロックした時
                /// </summary>
                OnMeBlockNTimes = 41,

                /// <summary>
                /// 自身のターンアクション開始時
                /// </summary>
                OnMeTurnActionStart = 42,

                /// <summary>
                /// 自身のターンアクション終了時
                /// </summary>
                OnMeTurnActionEnd = 43,

                /// <summary>
                /// 自身に当該状態異常が付与されたときと自身のターンアクション終了時(継続ダメージ系の状態異常用)
                /// </summary>
                OnTargetBattleConditionAddedAndMeTurnActionEnd = 44,

                /// <summary>
                /// 味方がウルトを使った後
                /// </summary>
                AfterAllyUltimateSkill = 45,

                /// <summary>
                /// 自身に当該状態異常が特定個数個付与されたとき
                /// </summary>
                OnTargetNumMyselfBattleConditionAdded = 46,
            }

            /// <summary>
            /// 状態異常のバフタイプ
            /// </summary>
            public enum BuffType {
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
            public enum ActivateConditionType {
                None = 0,

                /// <summary>
                /// HPがn%未満の時
                /// </summary>
                UnderPercentHP = 1,

                /// <summary>
                /// 生きている時
                /// </summary>
                Alive = 2,

                /// <summary>
                /// 戦闘不能の時
                /// </summary>
                Dead = 3,

                /// <summary>
                /// 特定状態異常が付与されている時
                /// </summary>
                HaveBattleCondition = 4,

                /// <summary>
                /// 回復可能
                /// 生きているかつ体力が満タンではない時
                /// </summary>
                Healable = 5,

                /// <summary>
                /// エネルギー上昇可能な時
                /// エネルギーが最大値ではない時
                /// </summary>
                EnableEnergyUp = 6,

                /// <summary>
                /// エネルギー減少可能な時
                /// エネルギーが0ではない時
                /// </summary>
                EnableEnergyDown = 7,

                /// <summary>
                /// 当該状態異常が特定個数付与されている時(アクション状態異常用)
                /// </summary>
                HaveMyselfBattleConditionNum = 8,
            }

            /// <summary>
            /// スキルタイプ
            /// </summary>
            public enum SkillType {
                None = 0,

                /// <summary>
                /// 攻撃
                /// </summary>
                Attack = 1,

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

                /// <summary>
                /// エネルギー上昇
                /// </summary>
                EnergyUp = 6,

                /// <summary>
                /// エネルギー減少
                /// </summary>
                EnergyDown = 7,

                /// <summary>
                /// ステータス変化
                /// </summary>
                Status = 8,

                /// <summary>
                /// ダメージ
                /// </summary>
                Damage = 9,

                /// <summary>
                /// 様々な要因を無視したダメージ
                /// 燃焼ダメージなど
                /// </summary>
                WithoutFactorDamage = 10,
            }

            /// <summary>
            /// 状態異常の効果量タイプ
            /// </summary>
            public enum BattleConditionActionValueType {
                None = 0,

                /// <summary>
                /// 固定値
                /// 付与時に計算し、その固定値を常に与える
                /// </summary>
                Fixed = 1,

                /// <summary>
                /// 変化値
                /// 効果発動時に毎度計算し、その値を与える
                /// </summary>
                Changed = 2,
            }

            /// <summary>
            /// アクションタイプ
            /// </summary>
            public enum BattleActionType {
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

                /// <summary>
                /// 状態異常ターン進行
                /// </summary>
                ProgressBattleConditionTurn,
            }

            /// <summary>
            /// バトル用のモンスターステータスタイプ
            /// </summary>
            public enum BattleMonsterStatusType {
                None = 0,
                Hp = 1, // 最大HP
                Attack = 2,
                Defense = 3,
                Heal = 4,
                Speed = 5,
                Sheild = 6,
                UltimateSkillDamageRate = 7,
                BlockRate = 8,
                CriticalRate = 9,
                CriticalDamageRate = 10,
                BuffResistRate = 11,
                DebuffResistRate = 12,
                DamageResistRate = 13,
                LuckDamageRate = 14,
                HolyDamageRate = 15,
                EnergyUpRate = 16,
                HealedRate = 17,
                AttackAccuracyRate = 18,
                Armor = 19, // 未使用
                ArmorBreakRate = 20, // 未使用
                HealingRate = 21,
                DefensePenetratingRate = 22,
                CurrentHp = 23,
            }

            /// <summary>
            /// スキルの発動回数制限タイプ
            /// </summary>
            public enum SkillExecuteNumLimitType {
                None = 0,

                /// <summary>
                /// バトル内で
                /// </summary>
                InBattle = 1,

                /// <summary>
                /// 1ウェーブ内で
                /// </summary>
                InWave = 2,

                /// <summary>
                /// 1ターン内で
                /// </summary>
                InTurn = 3,

                /// <summary>
                /// 1ストリーム内で
                /// 1つのスキル効果に対する処理内で
                /// </summary>
                InStream = 4,

                /// <summary>
                /// 自身の効果に対する効果に対して
                /// AからB→BからAに対して何回まで効果発動を許可するか
                /// 反撃系で使用する
                /// </summary>
                InEffectOnOwnEffect = 5,
            }

            /// <summary>
            /// スキル演出の位置タイプ
            /// </summary>
            public enum SkillFxPositionType {
                None = 0,

                /// <summary>
                /// 対象の個人
                /// </summary>
                TargetIndividual = 1,

                /// <summary>
                /// 対象の全体
                /// </summary>
                TargetWhole = 2,

                /// <summary>
                /// スキル発動者自身
                /// </summary>
                Myself = 3,

                /// <summary>
                /// スキル発動者全体
                /// </summary>
                MyWhole = 4,

                /// <summary>
                /// 画面全体
                /// </summary>
                StageWhole = 5,
            }

            public enum BattleSpeed {
                None = 0,

                /// <summary>
                /// 1倍
                /// </summary>
                One = 1,

                /// <summary>
                /// 2倍
                /// </summary>
                TwoTimes = 2,

                /// <summary>
                /// 4倍
                /// </summary>
                FourTimes = 3,
            }
        }

        namespace UI {
            /// <summary>
            /// ダイアログのレスポンス種類
            /// </summary>
            public enum DialogResponseType {
                None,
                Yes,
                No,
            }

            /// <summary>
            /// ウインドウのレスポンス種類
            /// </summary>
            public enum WindowResponseType {
                None,
                Yes,
                No,
            }

            /// <summary>
            /// コモンダイアログタイプ
            /// </summary>
            public enum CommonDialogType {
                NoAndYes,
                YesOnly,
            }

            /// <summary>
            /// フッタータイプ
            /// </summary>
            [Serializable]
            public enum FooterType {
                Home = 0,
                Monster = 1,
                Gacha = 2,
                Shop = 3,
            }

            /// <summary>
            /// アイコン画像タイプ
            /// </summary>
            public enum IconImageType {
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

                /// <summary>
                /// モンスターレアリティ
                /// </summary>
                MonsterRarity = 6,

                /// <summary>
                /// ガチャバナー
                /// </summary>
                GachaBanner = 7,
            }

            /// <summary>
            /// スタッカブルダイアログの優先度
            /// 低いものから表示される
            /// </summary>
            public enum StackableDialogPriority {
                None = 0,
                LoginBonus,
                News,
            }

            /// <summary>
            /// ロッカブルのロックタイプ
            /// </summary>
            public enum LockType {
                None = 0,

                /// <summary>
                /// ロック中はブロッカーを表示する
                /// </summary>
                ShowBlocker = 1,

                /// <summary>
                /// ロック中は非表示にする
                /// </summary>
                MakeInvisible = 2,
            }

            /// <summary>
            /// プロパティパネルタイプ
            /// </summary>
            public enum PropertyPanelType {
                /// <summary>
                /// オーブ
                /// </summary>
                Orb = 0,

                /// <summary>
                /// コイン
                /// </summary>
                Coin = 1,

                /// <summary>
                /// ガチャチケット
                /// </summary>
                GachaTicket = 2,

                /// <summary>
                /// SSR確定ガチャチケット
                /// </summary>
                SsrGachaTicket = 3,

                /// <summary>
                /// ブランク1
                /// </summary>
                Blank1 = 4,
            }
        }

        namespace Item {
            /// <summary>
            /// アイテムタイプ
            /// インベントリアイテムのクラスとも対応
            /// </summary>
            public enum ItemType {
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
            public enum VirtualCurrencyType {
                /// <summary>
                /// オーブ
                /// </summary>
                OB = 1,

                /// <summary>
                /// コイン
                /// </summary>
                CN = 2,
            }

            public static class VirtualCurrencyTypeExtends {
                public static string Name(this VirtualCurrencyType type) {
                    switch (type) {
                        case VirtualCurrencyType.OB:
                            return "オーブ";

                        case VirtualCurrencyType.CN:
                            return "コイン";

                        default:
                            return "";
                    }
                }
            }

            /// <summary>
            /// 資産タイプ
            /// PropertyMBのIDと対応
            /// </summary>
            public enum PropertyType {
                None = 0,

                /// <summary>
                /// 火の覚醒素材1
                /// </summary>
                RedGradeUpMaterial1 = 1,

                /// <summary>
                /// 水の覚醒素材1
                /// </summary>
                BlueGradeUpMaterial1 = 2,

                /// <summary>
                /// 木の覚醒素材1
                /// </summary>
                GreenGradeUpMaterial1 = 3,

                /// <summary>
                /// 光の覚醒素材1
                /// </summary>
                YellowGradeUpMaterial1 = 4,

                /// <summary>
                /// 闇の覚醒素材1
                /// </summary>
                PurpleGradeUpMaterial1 = 5,

                /// <summary>
                /// 火の覚醒素材2
                /// </summary>
                RedGradeUpMaterial2 = 6,

                /// <summary>
                /// 水の覚醒素材2
                /// </summary>
                BlueGradeUpMaterial2 = 7,

                /// <summary>
                /// 木の覚醒素材2
                /// </summary>
                GreenGradeUpMaterial2 = 8,

                /// <summary>
                /// 光の覚醒素材2
                /// </summary>
                YellowGradeUpMaterial2 = 9,

                /// <summary>
                /// 闇の覚醒素材2
                /// </summary>
                PurpleGradeUpMaterial2 = 10,

                /// <summary>
                /// 火の覚醒素材3
                /// </summary>
                RedGradeUpMaterial3 = 11,

                /// <summary>
                /// 水の覚醒素材3
                /// </summary>
                BlueGradeUpMaterial3 = 12,

                /// <summary>
                /// 木の覚醒素材3
                /// </summary>
                GreenGradeUpMaterial3 = 13,

                /// <summary>
                /// 光の覚醒素材3
                /// </summary>
                YellowGradeUpMaterial3 = 14,

                /// <summary>
                /// 闇の覚醒素材3
                /// </summary>
                PurpleGradeUpMaterial3 = 15,

                /// <summary>
                /// 火の覚醒素材4
                /// </summary>
                RedGradeUpMaterial4 = 16,

                /// <summary>
                /// 水の覚醒素材4
                /// </summary>
                BlueGradeUpMaterial4 = 17,

                /// <summary>
                /// 木の覚醒素材4
                /// </summary>
                GreenGradeUpMaterial4 = 18,

                /// <summary>
                /// 光の覚醒素材4
                /// </summary>
                YellowGradeUpMaterial4 = 19,

                /// <summary>
                /// 闇の覚醒素材4
                /// </summary>
                PurpleGradeUpMaterial4 = 20,

                /// <summary>
                /// 虹の覚醒素材1
                /// </summary>
                RainbowGradeUpMaterial1 = 21,

                /// <summary>
                /// スタミナ回復アイテム
                /// </summary>
                StaminaRecovery = 22,

                /// <summary>
                /// プレイヤー経験値
                /// </summary>
                PlayerExp = 23,

                /// <summary>
                /// モンスター経験値
                /// </summary>
                MonsterExp = 24,

                /// <summary>
                /// ガチャチケット
                /// </summary>
                GachaTicket = 25,

                /// <summary>
                /// SSR確定ガチャチケット
                /// </summary>
                SsrGachaTicket = 26,
            }

            /// <summary>
            /// アイコン色タイプ
            /// </summary>
            public enum IconColorType {
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
            public enum TextColorType {
                White = 0,
                Focus = 1,
            }

            /// <summary>
            /// テキストカラー拡張
            /// </summary>
            public static class TextColorTypeExtends {
                private static readonly Dictionary<TextColorType, string> ColorDictionary = new Dictionary<TextColorType, string>() {
                    { TextColorType.White, "#FFFFFF" },
                    { TextColorType.Focus, "#F6E19C" },
                };

                /// <summary>
                /// テキストカラーを取得
                /// </summary>
                public static string Color(this TextColorType textColorType) {
                    return ColorDictionary.ContainsKey(textColorType) ? ColorDictionary[textColorType] : "#FFFFFF";
                }
            }
        }

        namespace Gacha {
            /// <summary>
            /// ガチャのドロップテーブルタイプ
            /// </summary>
            public enum DropTableType {
                /// <summary>
                /// レア召喚（シングル）
                /// </summary>
                NormalGachaSingle = 1,
            }

            /// <summary>
            /// どのようなモンスターが排出するガチャなのかを示す値
            /// どのタイプのガチャから排出するモンスターなのかを示す値
            /// </summary>
            public enum GachaBoxType {
                /// <summary>
                /// 通常ガチャ
                /// </summary>
                Normal = 1,

                /// <summary>
                /// 月末限定ガチャ
                /// </summary>
                LimitedEndOfMonth = 2,
            }

            public enum GachaOpenType {
                None = 0,

                /// <summary>
                /// GachaScheduleMBに従う
                /// </summary>
                Schedule = 1,

                /// <summary>
                /// GachaBoxDetailMB.displayConditionListに従う
                /// </summary>
                Condition = 2,
            }

            public enum GachaExecuteType {
                /// <summary>
                /// 通常単発
                /// </summary>
                One = 1,

                /// <summary>
                /// 通常十連
                /// </summary>
                Ten = 2,

                /// <summary>
                /// SR以上1体確定十連
                /// </summary>
                TenUpperSR1 = 3,

                /// <summary>
                /// SSR1体確定十連
                /// </summary>
                TenUpperSSR1 = 4,

                /// <summary>
                /// SSR1体確定単発
                /// </summary>
                OneUpperSSR1 = 5,
            }

            /// <summary>
            /// ガチャ実行タイプ拡張
            /// </summary>
            public static class GachaExecuteTypeExtends {
                /// <summary>
                /// ガチャ実行タイプごとのガチャ回数を取得
                /// </summary>
                public static int Num(this GachaExecuteType type) {
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

        namespace Data {
            /// <summary>
            /// ユーザーデータをPlayFabに保存する時のKey名
            /// UserDataInfoのパラメータ名と同じにする必要がある
            /// </summary>
            public enum UserDataKey {
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
                userLoginBonusList,
                userGachaHistoryList,
                registeredDateTime,
                userRewardAdList,
                userNewsList,
            }
        }

        namespace Quest {
            /// <summary>
            /// クエストタイプ
            /// </summary>
            public enum QuestType {
                /// <summary>
                /// メイン
                /// </summary>
                Normal = 1,

                /// <summary>
                /// イベント
                /// 降臨など
                /// </summary>
                Event = 2,

                /// <summary>
                /// ゲリラ
                /// 育成素材用
                /// </summary>
                Guerrilla = 3,
            }
        }

        namespace Mission {
            /// <summary>
            /// ミッションタイプ
            /// </summary>
            public enum MissionType {
                Main = 1,
                Daily = 2,
                Weekly = 3,
                Monthly = 4,
                Event = 5,
            }
        }

        namespace Monster {
            /// <summary>
            /// 属性
            /// </summary>
            public enum MonsterAttribute {
                Red = 1,
                Blue = 2,
                Green = 3,
                Yellow = 4,
                Purple = 5,
            }

            public static class MonsterAttributeExtends {
                /// <summary>
                /// selfがtargetに対して有利か否か
                /// </summary>
                public static bool IsAdvantageous(this MonsterAttribute self, MonsterAttribute target) {
                    switch (self) {
                        case MonsterAttribute.Red:
                            return target == MonsterAttribute.Green;

                        case MonsterAttribute.Blue:
                            return target == MonsterAttribute.Red;

                        case MonsterAttribute.Green:
                            return target == MonsterAttribute.Blue;

                        case MonsterAttribute.Yellow:
                            return target == MonsterAttribute.Purple;

                        case MonsterAttribute.Purple:
                            return target == MonsterAttribute.Yellow;

                        default:
                            return false;
                    }
                }

                /// <summary>
                /// selfがtargetに対して不利か否か
                /// </summary>
                public static bool IsDisadvantage(this MonsterAttribute self, MonsterAttribute target) {
                    switch (self) {
                        case MonsterAttribute.Red:
                            return target == MonsterAttribute.Blue;

                        case MonsterAttribute.Blue:
                            return target == MonsterAttribute.Green;

                        case MonsterAttribute.Green:
                            return target == MonsterAttribute.Red;

                        case MonsterAttribute.Yellow:
                            return target == MonsterAttribute.Purple;

                        case MonsterAttribute.Purple:
                            return target == MonsterAttribute.Yellow;

                        default:
                            return false;
                    }
                }
            }

            /// <summary>
            /// 属性相性タイプ
            /// </summary>
            public enum MonsterAttributeCompatibilityType {
                None = 0,

                /// <summary>
                /// 有利
                /// </summary>
                Advantage = 1,

                /// <summary>
                /// 不利
                /// </summary>
                Disadvantage = 2,
            }

            /// <summary>
            /// レアリティ
            /// </summary>
            public enum MonsterRarity {
                None = 0,
                N = 1,
                R = 2,
                SR = 3,
                SSR = 4,
            }

            public enum MonsterState {
                None = 0,
                Idle = 1,
                Attack = 2,
                Breathing = 3,
                Run = 4,
                Hit = 5,
                Death = 6,
            }
        }

        namespace Condition {
            /// <summary>
            /// 条件タイプ
            /// </summary>
            public enum ConditionType {
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
                /// 指定したプレイヤーランク未満か
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
                /// 通算ログイン日数が指定日数未満か
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

                /// <summary>
                /// 本日が対象の曜日か
                /// リストで指定
                /// 文字列の欄に　0,3,5 のように
                /// 日曜=0 ~ 土曜=6
                /// </summary>
                TargetDayOfWeekToday = 14,

                /// <summary>
                /// 指定ガチャ詳細を引いている回数が指定回数以上か
                /// valueInt: gachaBoxDetailId
                /// valueString: 回数
                /// </summary>
                UpperGachaBoxDetailIdExecutedTimes = 15,

                /// <summary>
                /// 指定ガチャ詳細を引いている回数が指定回数未満か
                /// valueInt: gachaBoxDetailId
                /// valueString: 回数
                /// </summary>
                LowerGachaBoxDetailIdExecutedTimes = 16,

                /// <summary>
                /// 指定素材の所持数が指定数以上か
                /// valueInt: propertyId
                /// valueString: 数
                /// </summary>
                UpperPropertyNum = 17,

                /// <summary>
                /// 指定素材の所持数が指定数未満か
                /// valueInt: propertyId
                /// valueString: 回数
                /// </summary>
                LowerPropertyNum = 18,

                /// <summary>
                /// ユーザー登録から○○秒経過以上か
                /// </summary>
                UpperElapsedSecondsFromRegistration = 19,

                /// <summary>
                /// ユーザー登録から○○秒経過未満か
                /// </summary>
                LowerElapsedSecondsFromRegistration = 20,
            }
        }

        namespace Notification {
            /// <summary>
            /// 通知タイプ
            /// </summary>
            public enum NotificationType {
                None = 0,

                /// <summary>
                /// イベントの通知
                /// スタッカブル表示させたいもの
                /// </summary>
                NoticeEvent = 999,
            }

            /// <summary>
            /// 通知イベントタイプ
            /// </summary>
            public enum NotificationNoticeEventType {
                None = 0,

                /// <summary>
                /// ログインボーナス
                /// </summary>
                LoginBonus,

                /// <summary>
                /// お知らせ
                /// </summary>
                News,
            }

            /// <summary>
            /// 繰り返しタイプ
            /// </summary>
            public enum RepeatType {
                /// <summary>
                /// 繰り返しなし
                /// </summary>
                None,

                /// <summary>
                /// ログインする度
                /// </summary>
                EveryLogIn,

                /// <summary>
                /// 1日1回
                /// </summary>
                OnceADay,
            }
        }

        namespace News {
            /// <summary>
            /// お知らせタイプ
            /// </summary>
            public enum NewsType {
                None,

                /// <summary>
                /// メッセージ
                /// </summary>
                Message,

                /// <summary>
                /// プレゼント付与
                /// </summary>
                Present,
            }
        }

        namespace Sound {
            /// <summary>
            /// BGMのファイル名
            /// Enum名はそのファイル名にする
            /// </summary>
            public enum BGM {
                None,
                Main,
            }

            public enum SE {
                None,
                Click,
            }
        }

        namespace LoginBonus {
            public enum RepeatType {
                /// <summary>
                /// 繰り返しなし
                /// </summary>
                None = 0,

                /// <summary>
                /// 繰り返し条件なし
                /// </summary>
                Always = 1,

                /// <summary>
                /// 日付
                /// </summary>
                Date = 2,

                /// <summary>
                /// 曜日 日:0-土:6
                /// </summary>
                DayOfWeek = 3,
            }
        }

        namespace SortOrder {
            public enum SortOrderTypeMonster {
                Id = 0,
                Attribute = 1,
                Rarity = 2,
                Level = 3,
                Grade = 4,
                Luck = 5,
                Hp = 6,
                Attack = 7,
                Defense = 8,
                Speed = 9,
            }
        }

        namespace Loading {
            public enum TitleLoadingPhase {
                Start = 0,
                PlayFabLogin = 10,
                GetTitleData = 24,
                FirstLogin = 36,
                PMLogin = 43,
                GetPlayerProfile = 52,
                GetUserData = 67,
                GetUserInventory = 72,
                UpdateUserTitleDisplayName = 84,
                InitializeAddressables = 92,
                End = 100,
            }
        }

        namespace Date {
            public enum TermType {
                None = 0,

                /// <summary>
                /// 1日
                /// </summary>
                Day = 1,
            }
        }
    }
}
