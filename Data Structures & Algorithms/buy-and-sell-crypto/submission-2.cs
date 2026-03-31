public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int n = prices.Length;

        int left =0; 
        for(int right=1; right<n ; right++){
            if(prices[right] < prices[left]) left= right;
            else{
                max = Math.Max(prices[right]-prices[left], max);
            }
        }

        return max;
        
    }
}
