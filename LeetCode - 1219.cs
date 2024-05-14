public class Solution
{
    int[] direction = { 0, 1, 0, -1, 0 };

    public int GetMaximumGold(int[][] grid)
    {
        int row = grid.Length;
        int column = grid[0].Length;
        int result = 0;

        for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                result = Math.Max(result, DFS(grid, row, column, i, j));

        return result;
    }

    public int DFS(int[][] grid, int row, int column, int m, int n)
    {
        if (m < 0 || n < 0 || m == row || n == column || grid[m][n] == 0) return 0;

        int maxGold = 0;
        int amount = grid[m][n];
        grid[m][n] = 0;

        for (int i = 0; i < 4; i++)
        {
            int nextRow = m + direction[i];
            int nextCol = n + direction[i + 1];
            maxGold = Math.Max(maxGold, DFS(grid, row, column, nextRow, nextCol));
        }

        grid[m][n] = amount;
        return maxGold + amount;
    }
}