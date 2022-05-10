public class Solution {
        public int CalculateTime(string keyboard, string word)
        {
            var dict = new Dictionary<char, int>();
            for(var i = 0; i < keyboard.Length; i++)
            {
                dict.Add(keyboard[i], i);
            }
            int result = 0, current = 0; ;
            for(var i = 0; i < word.Length; i++)
            {
                var next = dict[word[i]];
                result += Math.Abs(current - next);
                current = next;
            }
            return result;
        }
}