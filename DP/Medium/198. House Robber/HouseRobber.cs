public class Solution {
        private Dictionary<int, int> robDict = new Dictionary<int, int>();
        public int Rob(int[] nums)
        {
                        if(nums.Length == 0)
            {
                return 0;
            }
            if(nums.Length == 1)
            {
                return nums[0];
            }
            robDict.Add(0, nums[0]);
            robDict.Add(1, Math.Max(nums[0], nums[1]));
            return RobRecursion(nums, nums.Length - 1);
        }
        private int RobRecursion(int[] nums, int i)
        {
            if (robDict.ContainsKey(i))
            {
                robDict.TryGetValue(i, out var val);
                return val;
            }
            int result = Math.Max(RobRecursion(nums, i - 1), RobRecursion(nums, i - 2) + nums[i]);
            robDict.Add(i, result);
            return result;
        }
}