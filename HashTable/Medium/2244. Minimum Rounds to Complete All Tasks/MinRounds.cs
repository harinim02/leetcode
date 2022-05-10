public class Solution {
public int MinimumRounds(int[] tasks)
        {
            var dict = new Dictionary<int, int>();
            int val = 0, result = 0;
            for(var i = 0; i < tasks.Length; i++)
            {
                dict.TryGetValue(tasks[i], out val);
                dict[tasks[i]] =  val + 1;
            }
            foreach (var key in dict.Keys)
            {
                dict.TryGetValue(key, out val);
                if(val < 2)
                {
                    return -1;
                }
                if(val == 2 || val == 3)
                {
                    result ++;
                }
                else { 
                
                    result += val / 3;
                    result += val % 3 != 0 ? 1 : 0;
                }
            }
            return result;
        }
}