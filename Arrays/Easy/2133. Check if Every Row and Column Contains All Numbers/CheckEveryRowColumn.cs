public class Solution {
public bool CheckValid(int[][] matrix)
        {
            var dict = new Dictionary<int, int>();
            for(int i = 0; i < matrix.Length; i++)
            {
                dict = new Dictionary<int, int>();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    
                    dict[matrix[i][j]] = 1;
                }
                if (dict.Count != matrix[i].Length)
                {
                    return false;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                dict = new Dictionary<int, int>();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    dict[matrix[j][i]] = 1;
                }

                if(dict.Count != matrix[i].Length)
                {
                    return false;
                }
            }
            return true;
        }
}