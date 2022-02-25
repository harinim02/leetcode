public class Solution {
public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<int>();
            var result = Enumerable.Repeat(0, temperatures.Length).ToArray();
            for(var i = 0; i < temperatures.Length; i++)
            {
                while(stack.Count >0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    result[stack.Peek()] = i - stack.Peek();
                    stack.Pop();
                }
                stack.Push(i);
            }
            return result;
        }
}