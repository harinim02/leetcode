public class Solution {
public bool IsValidSudoku(char[][] board)
        {
            var dict = new Dictionary<char, int>();
            int num = 0;
            // validate all rows
            for(var i = 0; i < 9; i++)
            {
                dict = new Dictionary<char, int>();
                for(var j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        dict.TryGetValue(board[i][j], out num);
                        if (num == 1)
                        {
                            return false;
                        }
                        dict.Add(board[i][j], 1);
                    }
                }
            }

            // validate all columns
            for (var j = 0; j < 9; j++)
            {
                dict = new Dictionary<char, int>();
                for (var i = 0; i < 9; i++)
                {
                    if (board[i][j] != '.')
                    {
                        dict.TryGetValue(board[i][j], out num);
                        if (num == 1)
                        {
                            return false;
                        }
                        dict.Add(board[i][j], 1);
                    }
                }
            }
            // Check individual blocks
            if (!ValidateSquares(0, 3, 0, 3, board)
            || !ValidateSquares(3, 6, 0, 3, board)
            || !ValidateSquares(6, 9, 0, 3, board)
            || !ValidateSquares(0, 3, 3, 6, board)
            || !ValidateSquares(3, 6, 3, 6, board)
            || !ValidateSquares(6, 9, 3, 6, board)
            || !ValidateSquares(0, 3, 6, 9, board)
            || !ValidateSquares(3, 6, 6, 9, board)
            || !ValidateSquares(6, 9, 6, 9, board)) return false;
            return true;
        }

        private bool ValidateSquares(int rowstart, int rowend, int colstart, int colend, char[][] board)
        {
            int num = 0;
            var dict = new Dictionary<char, int>();
            for (var i = rowstart; i < rowend; i++)
            {
                for (var j = colstart; j < colend; j++)
                {
                    if (board[i][j] != '.')
                    {
                        dict.TryGetValue(board[i][j], out num);
                        if (num == 1)
                        {
                            return false;
                        }
                        dict.Add(board[i][j], 1);
                    }
                }
            }
            return true;
        }
}