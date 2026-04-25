public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int left = 0;
        int right = prices.Count() - 1;

        int maximumProfit = 0;

        for (int i = 0; i < prices.Count(); i++)
        {
            int buyPrice = prices[i];
            for (int j = i + 1; j < prices.Count(); j++)
            {
                int sellPrice = prices[j];

                if (sellPrice - buyPrice > maximumProfit)
                {
                    maximumProfit = sellPrice - buyPrice;
                }

            }
        }

        return maximumProfit;
    }
}
