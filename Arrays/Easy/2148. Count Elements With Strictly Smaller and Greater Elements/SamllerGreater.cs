public class Solution {
        public int CountElements(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int min = int.MaxValue, max = int.MinValue;
            if(nums.Length < 3)
            {
                return 0;
            }
            for(int i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out int val);
                dict[nums[i]] = val + 1;
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            dict.TryGetValue(min, out var minItems);
            dict.TryGetValue(max, out var maxItems);
            var result = nums.Length - minItems - maxItems;
            if(result < 0)
            {
                result = 0;
            }
            return result;
        }
}