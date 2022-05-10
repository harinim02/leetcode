public class Solution {
private Dictionary<string, int> uniquePathDict = new Dictionary<string, int>();
        public int UniquePaths(int m, int n)
        {
            string key = $"{m}:{n}";

            if (uniquePathDict.ContainsKey(key))
            {
                uniquePathDict.TryGetValue(key, out var result);
                return result;
            }

            if(m==0 || n == 0)
            {
                return 0;
            }

            if (m == 1 && n == 1)
            {
                return 1;
            }

            var sum = UniquePaths(m, n - 1) + UniquePaths(m - 1, n);
            uniquePathDict.Add(key, sum);
            return sum;
        }
}