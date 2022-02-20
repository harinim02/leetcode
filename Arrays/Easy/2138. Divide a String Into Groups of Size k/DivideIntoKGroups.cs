public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        int fillCount = (k - (s.Length % k)) % k;
        for (int i = 0; i < fillCount; i++)
        {
            s = s + fill;
        }
        var words = new string[s.Length / k];
        int cursor = 0;
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = s.Substring(cursor, k);
            cursor += k;
        }
        return words;
    }
}