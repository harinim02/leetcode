public class Solution {
private Dictionary<string, int> uniquePathDict = new Dictionary<string, int>();

        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1) return 0;
            return UniquePaths(obstacleGrid, obstacleGrid.Length, obstacleGrid[0].Length);
        }
        public int UniquePaths(int [][] grid, int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            if (m == 1 && n == 1)
            {
                return 1;
            }

            if (grid[grid.Length - m][grid[0].Length - n] == 1)
            {
                return 0;
            }

            string key = $"{m}:{n}";

            if (uniquePathDict.ContainsKey(key))
            {
                uniquePathDict.TryGetValue(key, out var result);
                return result;
            }

            var sum = UniquePaths(grid, m, n - 1) + UniquePaths(grid, m - 1, n);
            uniquePathDict.Add(key, sum);
            return sum;
        }
}