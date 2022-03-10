public class Solution {
public int NumKLenSubstrNoRepeats(string s, int k)
        {
            int i = 0, j = 0;
            int result = 0;
            while(i<s.Length && j < s.Length)
            {
                var substring = s.Substring(i, j - i);
                while (j < s.Length && !substring.Contains(s[j]) && j-i<k)
                {
                    j++;
                    substring = s.Substring(i, j - i);
                }
                if(j-i == k)
                {
                    result++;
                    i++;
                }
                substring = s.Substring(i, j - i);
                while (i < j && j<s.Length && substring.Contains(s[j]) )
                {
                    i++;
                    substring = s.Substring(i, j - i);
                }
            }
            return result;
        }
}