public class Solution {
public long[] SumOfThree(long num)
        {
            if((num-3)%3 != 0)
            {
                return new long[] { };
            }
            long x = (num - 3) / 3;
            return new long[] { x, x + 1, x + 2 };
        }
}