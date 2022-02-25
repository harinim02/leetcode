public class Solution {
public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var stack = new Stack<int>();
            for(var i = 0; i < nums2.Length; i++)
            {
                while(stack.Count > 0 && stack.Peek() < nums2[i])
                {
                    dict.Add(stack.Peek(), nums2[i]);
                    stack.Pop();
                }
                stack.Push(nums2[i]);
            }
            while(stack.Count > 0)
            {
                dict.Add(stack.Peek(), -1);
                stack.Pop();
            }

            IList<int> result = new List<int>();
            int output = -1;
            for(var i = 0; i < nums1.Length; i++)
            {
                dict.TryGetValue(nums1[i], out output);
                result.Add(output);
            }
            return result.ToArray();
        }
}