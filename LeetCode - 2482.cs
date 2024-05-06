public class Solution
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        int[] ZeroColumn = new int[grid[0].Length];
        int[] ZeroRow = new int[grid.Length];
        int[] OneColumn = new int[grid[0].Length];
        int[] OneRow = new int[grid.Length];
        int[][] result = new int[grid.Length][];

        for (int i = 0; i < grid.Length; i++)
        {
            result[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    ZeroColumn[j]++;
                    ZeroRow[i]++;
                }
                else if (grid[i][j] == 1)
                {
                    OneColumn[j]++;
                    OneRow[i]++;
                }
            }
        }

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[i].Length; j++)
                result[i][j] = OneRow[i] + OneColumn[j] - ZeroRow[i] - ZeroColumn[j];

        return result;
    }
}
