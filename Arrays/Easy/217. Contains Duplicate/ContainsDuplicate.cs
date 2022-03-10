public class Solution {
        public bool ContainsDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int count = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out count);
                if(count == 1)
                {
                    return true;
                }
                dict.Add(nums[i], 1);
            }
            return false;
        }
}