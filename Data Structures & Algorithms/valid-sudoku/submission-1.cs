public class Solution 
{
    public bool IsValidSudoku(char[][] board)
    {
        int width = board.Count();

        if (!(AreValidRows(board) && AreValidColumns(board)))
        {
            return false;
        }

        for (int startRow = 0; startRow < width; startRow += 3)
        {
            for (int endColumn = 0; endColumn < width; endColumn += 3)
            {
                if (!isValid3x3(board, startRow, endColumn))
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool isValid3x3(char[][] board, int startRow, int endColumn)
    {
        List<int> found = new List<int>();
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                int current = char.IsDigit(board[startRow + row][endColumn + column]) ? board[startRow + row][endColumn + column] - '0' : -1;
                if (current == -1) continue;
                if (!found.Contains(current))
                {
                    found.Add(current);
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool AreValidRows(char[][] board)
    {
        int width = board.Count();
        for (int row = 0; row < width; row++)
        {
            List<int> found = new List<int>();
            for (int column = 0; column < width; column++)
            {
                int current = char.IsDigit(board[row][column]) ? board[row][column] - '0' : -1;
                if (current == -1) continue;

                if (found.Contains(current))
                {
                    return false;
                }
                else
                {
                    found.Add(current);
                }
            }
        }
        return true;
    }

        public static bool AreValidColumns(char[][] board)
    {
        int width = board.Count();
        for (int row = 0; row < width; row++)
        {
            List<int> found = new List<int>();
            for (int column = 0; column < width; column++)
            {
                int current = char.IsDigit(board[column][row]) ? board[column][row] - '0' : -1;
                if (current == -1) continue;

                if (found.Contains(current))
                {
                    return false;
                }
                else
                {
                    found.Add(current);
                }
            }
        }
        return true;
    }
}
