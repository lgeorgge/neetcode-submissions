public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int maxP = 0;
        for (int right = 1; right < prices.Length; right++){
            
            if (prices[left] < prices[right])
            {
                maxP = Math.Max(maxP, prices[right] - prices[left]);
            }
            else
            {
                left = right;
            }
        }
        return maxP;
    }
}
