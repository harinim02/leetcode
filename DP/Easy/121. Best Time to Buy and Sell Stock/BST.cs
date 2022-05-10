public class Solution {
        public int MaxProfit(int[] prices)
        {
            int largestDifference = 0;
            int minSoFar = int.MaxValue;
            for(var i = 0; i < prices.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, prices[i]);
                largestDifference = Math.Max(largestDifference, prices[i] - minSoFar);
            }
            return largestDifference;
        }
}