public class Solution {
public bool IsValid(string s)
        {
            var test = new StringBuilder();
            char open = '\0';
            var dict = new Dictionary<char, char>();
            dict.Add('}', '{');
            dict.Add(')', '(');
            dict.Add(']', '[');
            for (int i = 0; i < s.Length; i++)
            {
                var t = s[i];
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    test.Append(s[i]);
                }
                else
                {
                    if(test.Length == 0)
                    {
                        return false;
                    }
                    open = test[test.Length - 1];
                    dict.TryGetValue(s[i], out var actualOpen);
                    if(open != actualOpen)
                    {
                        return false;
                    }
                    test.Remove(test.Length-1, 1);
                }
            }
            return test.Length == 0 ? true : false;
                
            
        }
}