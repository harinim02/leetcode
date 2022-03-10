public class Solution {
public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int result = 0;
            for(var i = 0; i < arr.Length; i++)
            {
                for(var j = i + 1; j < arr.Length; j++)
                {
                    for(var k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a
                            && Math.Abs(arr[j] - arr[k]) <= b
                            && Math.Abs(arr[k] - arr[i]) <= c)
                        {
                            result++;
                        }
                    }
                }

            }
            return result;
        }
}