public class Solution {
public string LongestCommonPrefix(string[] strs)
        {
            int counter = 0;
            var s = new StringBuilder();
            char c = '\0';
            while (true)
            {
                if(strs[0].Length > counter)
                {
                    c = strs[0][counter];
                }
                else
                {
                    break;
                }
                int i=1;
                for(; i < strs.Length; i++)
                {
                    if(strs[i].Length<=counter || strs[i][counter] != c)
                    {
                        break;
                    }
                }
                if(i == strs.Length)
                {
                    s.Append(c.ToString());
                    counter++;
                    c = '\0';
                }
                else
                {
                    break;
                }
            }
            return s.ToString();
        }
}