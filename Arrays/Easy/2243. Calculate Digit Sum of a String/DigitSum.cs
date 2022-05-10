public class Solution {
public string DigitSum(string s, int k)
        {
            int counter = 0, sum=0;
            string result = string.Empty;
            while (s.Length > k)
            {
                counter = 0;
                result = string.Empty;
                while (counter < s.Length)
                {
                    var s1 = counter + k < s.Length ? s.Substring(counter, k) : s.Substring(counter);
                    sum = 0;
                    for (int j = 0; j < s1.Length; j++)
                    {
                        sum += int.Parse(s1[j].ToString());
                    }
                    result += sum.ToString();
                    counter += k;
                }
                s = result;
            }
            return s;
        }
}