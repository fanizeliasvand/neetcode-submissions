public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0; 
        int left = 0; 
        for(int right = 0; right < prices.Length; right++)
        {
            if(prices[left] < prices[right])
            {
                maxProfit = Math.Max(prices[right] - prices[left], maxProfit); 
            }
            else left = right; 
            
        }
        return maxProfit; 
        
    }
}
