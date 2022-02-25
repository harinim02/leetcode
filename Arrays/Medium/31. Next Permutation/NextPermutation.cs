public class Solution {
private int[] Swap1(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;

            return nums;
        }

        private int[] Reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length-1;
            while (i < j)
            {
                nums = Swap1(nums, i, j);
                i++;
                j--;
            }
            return nums;
        }

        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i < 0)
            {
                Reverse(nums, 0);
                return;
            }
            int j = nums.Length - 1;
            while ((int)nums[j] <= (int)nums[i])
            {
                j--;
            }
            nums = Swap1(nums, i, j); ;
            nums = Reverse(nums, i + 1);
        }
}