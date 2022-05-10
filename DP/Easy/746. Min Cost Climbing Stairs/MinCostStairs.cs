public class Solution {
private Dictionary<int, int> stairsDict = new Dictionary<int, int>();
        public int MinCostClimbingStairs(int[] cost)
        {
            stairsDict.Add(0, cost[0]);
            stairsDict.Add(1, cost[1]);
            return Math.Min(StairsRecursion(cost, cost.Length - 1), StairsRecursion(cost, cost.Length - 2));
        }

        private int StairsRecursion(int[] cost, int i)
        {
            if (stairsDict.ContainsKey(i))
            {
                stairsDict.TryGetValue(i, out var val);
                return val;
            }
            var result = cost[i] + Math.Min(StairsRecursion(cost, i - 2), StairsRecursion(cost, i - 1));
            stairsDict.Add(i, result);
            return result;
        }
}