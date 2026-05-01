public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (int[] row in matrix)
        {
            foreach (int column in row)
            {
                if (column == target)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
