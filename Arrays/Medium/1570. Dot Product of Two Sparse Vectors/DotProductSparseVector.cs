public class SparseVector
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public SparseVector(int[] nums)
        {
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    dict.Add(i, nums[i]);
                }
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            int result = 0, num1 = 0, num2 = 0;
            foreach (var key in dict.Keys)
            {
                dict.TryGetValue(key, out num1);
                vec.dict.TryGetValue(key, out num2);
                result += num1 * num2;
            }
            return result;
        }
    }