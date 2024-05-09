public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);
        var counts = 0;
        long result = 0;
        for (int i = happiness.Length - 1; i >= 0 && k > 0; i--)
        {
            k--;
            if (happiness[i] - counts > 0)
            {
                result += (happiness[i] - counts);
                counts++;
            }
        }
        return result;
    }
}