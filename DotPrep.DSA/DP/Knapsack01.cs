namespace DotPrep.DSA.DP
{
    public class Knapsack01
    {

        int[,] dp;

        public int Solve(int[] weights, int[] values, int capacity)
        {
            dp = new int[weights.Length + 1, capacity + 1];
            return GetMaxProfit(weights, values, capacity, weights.Length - 1);
        }

        int GetMaxProfit(int[] w, int[] v, int c, int pos)
        {
            if (c <= 0 || pos < 0) return 0;
            if (w[pos] <= c)
            {
                if (dp[c, pos-1] != -1) return dp[c, pos];
                else
                {
                    var profit = Math.Max(
                        v[pos] + GetMaxProfit(w, v, c - w[pos], pos - 1),
                        GetMaxProfit(w, v, c, pos - 1));
                    dp[c, pos-1] = profit;
                    return profit;
                }

            }
            else
            {
                if (dp[c, pos-1] != -1) return dp[c, pos];
                else
                {
                    var profit = GetMaxProfit(w, v, c, pos - 1);
                    dp[c, pos-1] = profit;
                    return profit;
                }
            }
        }
    }
}
