public class Solution {
public int MinimumCost(int[] cost)
        {
            int sum = 0;
            if(cost.Length == 1)
            {
                return cost[0];
            }
            if(cost.Length == 2)
            {
                return cost[0] + cost[1];
            }
            Array.Sort(cost);
            Array.Reverse(cost);
            for(int i = 0; i < cost.Length; i++)
            {
                if((i+1)%3 == 0)
                {
                    continue;
                }
                sum += cost[i];
            }
            return sum;
        }
}