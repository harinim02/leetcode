public class Solution {
public int[] SumZero(int n)
        {
            int[] result = new int[n];
            int k = n / 2, counter = 0;
            for(int i = k; i > 0; i--)
            {
                result[counter++] = -i;
                result[counter++] = i;
            }
            if(n%2 == 1)
            {
                result[counter] = 0;
            }
            return result;
        }
}