public class Solution {
public IList<int> MaxScoreIndices(int[] nums)
        {

            var zeros = new int[nums.Length+1];
            var ones = new int[nums.Length+1];
            zeros[0] = 0;
            for(var i = 1; i <=nums.Length; i++)
            {
                if(nums[i-1] == 0)
                {
                    zeros[i] = zeros[i - 1] + 1;
                }
                else
                {
                    zeros[i] = zeros[i - 1];
                }
            }
            ones[nums.Length] = 0; 
            for(var i = nums.Length-1; i >= 0; i--)
            {
                if(nums[i] == 1)
                {
                    ones[i] = ones[i + 1] + 1;
                }
                else
                {
                    ones[i] = ones[i + 1];
                }
            }

            int max = int.MinValue;
            var result = new List<int>();
            for(int i = 0; i < nums.Length + 1; i++)
            {
                int sum = zeros[i] + ones[i];
                if (max < sum)
                {
                    result.Clear();
                    result.Add(i);
                    max = sum;
                }else if(max == sum)
                {
                    result.Add(i);
                }
            }
            return result;
        }
}