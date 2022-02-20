public class Solution {
public int[] GetConcatenation(int[] nums)
        {
            var result = new int[nums.Length * 2];
            int i = 2, count = 0;
            while (i-- > 0)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    result[count++] = nums[j];
                }
            }
            return result;
        }
}