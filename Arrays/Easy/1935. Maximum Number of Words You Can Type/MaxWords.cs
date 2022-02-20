public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters)
        {
            int result = 0;
            bool flag = true;
            var words = text.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = 0; j < brokenLetters.Length; j++)
                {
                    if (words[i].Contains(brokenLetters[j].ToString()))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    result++;
                }else
                {
                    flag = true;
                }
            }
            return result;
        }
}