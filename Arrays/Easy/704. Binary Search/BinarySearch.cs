public class Solution {
            public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        private int BinarySearch(int[] nums, int start, int end, int k)
        {
            if(end >= start){
                int mid = start + ( end - start) / 2; // 8, 10 
                if(nums[mid] == k)
                {
                    return mid;
                }
                if(nums[mid] > k)
                {
                    return BinarySearch(nums, 0, mid-1, k);
                }
                else
                {
                    return BinarySearch(nums, mid + 1, end, k);
                }
            }
            return -1;
            
        }
}