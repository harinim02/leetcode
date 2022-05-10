public class Solution {
public int NumIdenticalPairs(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int occ = 0;
            int result = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out occ);
                dict[nums[i]] = occ + 1;
            }
            foreach (var key in dict.Keys)
            {
                if(dict[key] > 1)
                {
                    for(var i = 1; i < dict[key]; i++)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }
}