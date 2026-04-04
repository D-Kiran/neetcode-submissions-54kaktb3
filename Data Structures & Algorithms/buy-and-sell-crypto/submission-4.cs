public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int n = prices.Length;

       int minbuy = prices[0];

       for(int i=0; i<n; i++){
          max= Math.Max(max, prices[i]-minbuy);
          minbuy = Math.Min(minbuy, prices[i]);
       }

       return max;
    }
}
