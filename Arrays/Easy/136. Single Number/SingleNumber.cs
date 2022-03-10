public class Solution {
public int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int count = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out count);
                if(count == 1)
                {
                    // found the second occurrence, remove the entry
                    dict.Remove(nums[i]);
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            return dict.Keys.First();
        }
}