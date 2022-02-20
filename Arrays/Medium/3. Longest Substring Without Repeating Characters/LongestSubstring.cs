public class Solution {
    public int LengthOfLongestSubstring(string s)
        {
            int left = 0, right = 0, result = 0;
            var dict = new Dictionary<char, int>();
            int rightLetter, leftLetter;
            while(right < s.Length)
            {
                dict.TryGetValue(s[right], out rightLetter);
                dict[s[right]] = rightLetter + 1;
                while (dict[s[right]] > 1)
                {
                    dict.TryGetValue(s[left], out leftLetter);
                    dict[s[left]] = leftLetter-1;
                    left++;
                }
                
                result = Math.Max(result, right - left + 1);
                right++;
            }
            return result;
        }
}