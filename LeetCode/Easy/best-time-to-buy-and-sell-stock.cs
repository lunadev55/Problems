public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minBuy = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            maxProfit = Math.Max(maxProfit, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }

        if (maxProfit > 0)
            return maxProfit;
        return 0;
    }
}