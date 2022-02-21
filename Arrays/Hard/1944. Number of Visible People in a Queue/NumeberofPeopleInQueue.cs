public class Solution {
public int[] CanSeePersonsCount(int[] heights)
        {
            int count;
            Stack<int> stack = new Stack<int>();
            IList<int> result = new List<int>();
            for(int i = heights.Length - 1; i >= 0; i--)
            {
                count = 0;
                while(stack.Count!=0 && stack.Peek() < heights[i])
                {
                    stack.Pop();
                    count++;
                }
                var c = stack.Count == 0 ? 0 : 1;
                result.Add(count + c);
                stack.Push(heights[i]);
            }
            return result.Reverse().ToArray();
        }
}