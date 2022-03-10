public class Solution {
public string RestoreString(string s, int[] indices)
        {
            var c = Enumerable.Repeat('\0', s.Length);
            var dict = new Dictionary<int, char>();
            for(var i = 0; i < indices.Length; i++)
            {
                dict.Add(indices[i], s[i]);
            }
            StringBuilder str = new StringBuilder();
            char temp;
            for(var i = 0; i < indices.Length; i++)
            {
                dict.TryGetValue(i, out  temp);
                str.Append(temp);
            }
            return str.ToString();
        }
}