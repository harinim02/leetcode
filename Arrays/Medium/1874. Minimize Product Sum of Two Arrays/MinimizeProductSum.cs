public class Solution {
public int MinProductSum(int[] nums1, int[] nums2)
        {
            int result = 0;
            Array.Sort(nums1);
            Array.Sort(nums2);
            Array.Reverse(nums2);
            for(var i = 0; i < nums1.Length; i++)
            {
                result += (nums1[i] * nums2[i]);
            }
            return result;
        }
}