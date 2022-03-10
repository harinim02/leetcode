public class Solution {
        public int PrefixCount(string[] words, string pref)
        {
            int result = 0;
            for(var i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(pref))
                {
                    result++;
                }
            }
            return result;
        }
}