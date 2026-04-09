public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = int.MaxValue;
        foreach(int price in prices)
        { 
            int profit = price - min;
            if(profit > maxProfit) maxProfit = profit;
            if(price < min) min = price;
            
        }
        return maxProfit;
    }
}
