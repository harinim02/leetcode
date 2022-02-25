public class Solution {
public int[] NextGreaterElements(int[] nums)
        {
            int[] result = Enumerable.Repeat(-1, nums.Length).ToArray();
            var stack = new Stack<int>();
            for(var i = 0; i < nums.Length; i++)
            {
                while(stack.Count >0 && nums[stack.Peek()] < nums[i])
                {
                    result[stack.Peek()] = nums[i];
                    stack.Pop();
                }
                stack.Push(i);
            }
            if(stack.Count > 0)
            {
                for(var i = 0; i < nums.Length; i++)
                {
                    while(stack.Count >0 && nums[i] > nums[stack.Peek()])
                    {
                        result[stack.Peek()] = nums[i];
                        stack.Pop();
                    }
                }
            }
            return result;
        }
}