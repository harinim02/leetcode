public class Solution {
public int SearchInsert(int[] nums, int target)
        {
            if(target < nums[0])
            {
                return 0;
            }
            else if(target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            return BinarySearchInsert(nums, 0, nums.Length, target);
        }

        private int BinarySearchInsert(int[] nums, int start, int end, int k)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == k)
                {
                    return mid;
                }
                // needs to be inserted in front of nums[mid]
                else if (k < nums[mid])
                {
                    if (mid>0 && k > nums[mid - 1])
                    {

                        return mid;
                    }
                    else
                    {
                        return BinarySearchInsert(nums, 0, mid - 1, k);
                    }
                }
                else if (k > nums[mid])
                {
                    if (mid < nums.Length - 1 && k < nums[mid + 1])
                    {

                        return mid + 1;
                    }
                    else
                    {
                        return BinarySearchInsert(nums, mid + 1, end, k);
                    }
                } 
            }
            return -1;
        }
}