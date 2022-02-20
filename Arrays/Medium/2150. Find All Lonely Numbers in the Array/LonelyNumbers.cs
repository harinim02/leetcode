
public class Solution {
        public IList<int> FindLonely(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var output = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out int val);
                dict[nums[i]] = val+1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var x = nums[i];
                dict.TryGetValue(x, out int val);
                if (!dict.ContainsKey(x-1) 
                    && !dict.ContainsKey(x+1)
                    && val == 1)
                {
                    output.Add(x);
                }
            }
            return output;
        }
}