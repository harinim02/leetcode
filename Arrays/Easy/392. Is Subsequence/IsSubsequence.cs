public class Solution {
public bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while(j < t.Length && i < s.Length)
            {
                if(s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return (i == s.Length) ? true : false;
        }
}