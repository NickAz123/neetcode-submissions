public class Solution {
    public int MaxProfit(int[] prices) {
        
        if(prices.Length < 2){
            return 0;
        }

        int i = 0;
        int j = 1;

        int max = prices[j] - prices[i];

        while(j < prices.Length){
            if(prices[j] <= prices[i]){
                j++;
                i = j - 1;
            }else{
                while(j < prices.Length && prices[j] > prices[i]){
                    max = Math.Max(prices[j] - prices[i], max);
                    j++;
                }
            }
        }
        if(max < 0){
            return 0;
        }

        return max;
    }
}
