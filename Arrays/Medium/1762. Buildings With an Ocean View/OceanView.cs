public class Solution {
        public int[] FindBuildings(int[] heights)
        {
            IList<int> result = new List<int>();
            int max = int.MinValue;
            for (var i = heights.Length - 1; i >= 0; i--)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                    result.Add(i);
                }
            }
            return result.Reverse().ToArray();
        }
}