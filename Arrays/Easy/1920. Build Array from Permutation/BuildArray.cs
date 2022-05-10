public class Solution {
    public int[] BuildArray(int[] nums) {
                    IList<int> result = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[nums[i]]);
            }
            return result.ToArray();
    }
}