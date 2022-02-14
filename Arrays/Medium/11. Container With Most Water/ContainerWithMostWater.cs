public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, max = int.MinValue, capacity;

        while (right > left)
        {
            capacity = Math.Min(height[left], height[right]) * (right - left);
            max = Math.Max(capacity, max);
            if (height[left] <= height[right])
            {
                left++;

            }
            else
            {
                right--;
            }
        }
        return max;
    }
}