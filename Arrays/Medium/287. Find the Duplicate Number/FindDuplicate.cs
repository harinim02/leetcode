public class Solution {
        public int FindDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out var val);
                dict[nums[i]] = val + 1;
            }
            foreach(var d in dict.Keys)
            {
                dict.TryGetValue(d, out var val);
                if(val > 1)
                {
                    return d;
                }
            }
            return -1;
        }
}