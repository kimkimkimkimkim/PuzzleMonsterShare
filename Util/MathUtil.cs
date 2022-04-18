using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 数学関係を扱うUtil
/// </summary>
public static class MathUtil {
    /// <summary>
    /// 最大公約数を取得する
    /// </summary>
    public static int GetGcd(List<int> numList) {
        numList = numList.Distinct().ToList();
        if (numList.Count == 0) {
            return 0;
        } else if (numList.Count == 1) {
            return numList.First();
        } else {
            return CalculateGcd(numList);
        }
    }

    /// <summary>
    /// 最小公倍数を取得する
    /// </summary>
    public static int GetLcm(List<int> numList) {
        numList = numList.Distinct().ToList();
        if (numList.Count == 0) {
            return 0;
        } else if (numList.Count == 1) {
            return 1;
        } else {
            return CalculateLcm(numList);
        }
    }

    /// <summary>
    /// 最大公約数を計算する
    /// </summary>
    private static int CalculateGcd(List<int> numList) {
        var count = numList.Count;

        // ユークリッドの互除法を末尾2要素にかける
        var num1 = numList[count - 1];
        var num2 = numList[count - 2];
        var remainder = num1 % num2;
        if (remainder == 0) {
            if (count == 2) {
                // 割り切れたかつ要素が2つなら割った数が最大公約数
                return num2;
            } else {
                // 割り切れた場合は割られた数の最大公約数と割った数が等しいので割られた数をリストから削除し再実行
                numList.RemoveAt(count - 1);
                return CalculateGcd(numList);
            }
        } else {
            // あまりがあった場合は割った数を割られる数にし、余りを割る数にする
            numList[count - 1] = num2;
            numList[count - 2] = remainder;
            return CalculateGcd(numList);
        }
    }

    /// <summary>
    /// 最小公倍数を計算する
    /// </summary>
    private static int CalculateLcm(List<int> numList) {
        // 「2数の積」を「最大公約数」で割ったものが「最小公倍数」という性質を末尾2要素に適用
        var count = numList.Count;
        var num1 = numList[count - 1];
        var num2 = numList[count - 2];
        var gcd = GetGcd(new List<int>() { num1, num2 });
        var quotient = num1 * num2 / gcd;

        if (count == 2) {
            return quotient;
        } else {
            numList[count - 2] = quotient;
            numList.RemoveAt(count - 1);
            return CalculateLcm(numList);
        }
    }
}