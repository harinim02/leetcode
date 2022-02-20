public class Solution {
    public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict.TryGetValue(nums[i], out var t);
                    return new int[] { i, t };
                }
                if(!dict.ContainsKey(target-nums[i]))
                {
                    dict.Add(target - nums[i], i);
                }
            }
            return new int[2] {0,0 };
        }
}