public class Solution {
public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int i = 0, j = people.Length - 1;
            int result = 0;
            while(i<people.Length && j>=0 && i <= j)
            {
                if(people[j] + people[i] <=limit)
                {
                    i++;
                }
                j--;
                result++;
            }
            return result;
        }
}