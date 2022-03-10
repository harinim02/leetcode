public class Solution {
public void ReverseString(char[] s)
        {
            s = ReverseRecurse(s, 0, s.Length - 1);
        }

        private char[] ReverseRecurse(char[] s, int i, int j)
        {
            if(i>= j)
            {
                return s;
            }
            SwapString(s, i++, j--);
            return ReverseRecurse(s, i, j);
        }

        private void SwapString(char[] s, int i, int j)
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }

}