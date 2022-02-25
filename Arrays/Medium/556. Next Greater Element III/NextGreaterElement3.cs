public class Solution {
private char[] Swap(char[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;

            return nums ;
        }

        private char[] Reverse(char[] nums, int start)
        {
            int i = start, j = nums.Length-1;
            while (i < j)
            {
                nums = Swap(nums, i, j);
                i++;
                j--;
            }
            return nums;
        }

        public int NextGreaterElement(int n)
        {
            string nums = n.ToString();
            int i = nums.Length - 2;
            while( i >= 0 && (int)nums[i+1] <= (int)nums[i])
            {
                i--;
            }
            if(i < 0)
            {
                return -1;
            }
            int j = nums.Length - 1;
            while ((int)nums[j] <= (int)nums[i])
            {
                j--;
            }
            var nums1 = nums.ToCharArray();
            nums1 = Swap(nums1, i, j); ;
            nums1 = Reverse(nums1, i + 1);
            int.TryParse(new string(nums1), out int result);
            if( result == 0)
            {
                return -1;
            }
            return result;
        }
    }
