public class Solution {
    public int MaxProfit(int[] prices) {
        int max = Int32.MinValue;
        int n = prices.Length;

        for(int i=0; i<n; i++){
            int buyingprice = prices[i];
            for(int j=i+1; j<n;j++){
                int sellingprice = prices[j];
                if(sellingprice < buyingprice) continue;
                int profit = sellingprice-buyingprice;
                max = Math.Max(max,profit);
            }
        }

        if(max < 0) return 0;
        return max;
    }
}
