public class Solution {
        public int FindFinalValue(int[] nums, int original)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = 1;
            }
            int val;
            while (dict.TryGetValue(original, out val) && val == 1)
            {
                original *= 2;
            }
            return original;
        }
}