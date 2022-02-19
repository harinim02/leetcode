public class Solution {
public int CountPairs(int[] nums, int k)
        {
            int result = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j] && (i*j)%k == 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
}