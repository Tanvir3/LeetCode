public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int[][] answer = new int[grid.Length - 2][];

        for (int i = 0; i < grid.Length - 2; i++)
        {
            answer[i] = new int[grid[0].Length - 2];
            for (int j = 0; j < grid[0].Length - 2; j++)
                answer[i][j] = FindMaximum(grid, i, j);
        }

        return answer;
    }

    public int FindMaximum(int[][] grid, int m, int n)
    {
        int result = 0;

        for (int i = m; i < m + 3; i++)
            for (int j = n; j < n + 3; j++)
                result = Math.Max(grid[i][j], result);

        return result;
    }
}