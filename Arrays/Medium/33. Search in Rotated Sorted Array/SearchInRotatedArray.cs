public class Solution {
public int Search(int[] nums, int target)
        {
            int i = 0;
            while (i < nums.Length-1)
            {
                if(nums[i] < nums[i+1])
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            if(i == nums.Length - 1)
            {
                return BinarySearch(nums, 0, nums.Length-1, target);
            }
            if(target < nums[0])
            {
                return BinarySearch(nums, i+1, nums.Length - 1, target);
            }
            else
            {
                return BinarySearch(nums, 0, i, target);
            }
        }

        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            int mid = (start + end) / 2;
            if(target == nums[mid])
            {
                return mid;
            }
            if(start >= end)
            {
                return -1;
            }
            if(target < nums[mid])
            {
                return BinarySearch(nums, start, mid, target);
            }
            return BinarySearch(nums, mid + 1, end, target);
        }
}