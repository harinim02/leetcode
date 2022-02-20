public class Solution {
        public string CapitalizeTitle(string title)
        {
            var result = new StringBuilder();
            var words = title.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length < 3)
                {
                    result.Append(words[i].ToLower());
                    result.Append(" ");
                }
                else
                {
                    result.Append(words[i][0].ToString().ToUpper() + words[i].Substring(1).ToLower());
                    result.Append(" ");
                }
            }
            return result.ToString().TrimEnd(' ');
        }
}