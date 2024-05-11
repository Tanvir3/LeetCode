public class Solution
{
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        int n = arr.Length;
        double low = 0, high = 1;

        while (low < high)
        {
            double mid = (low + high) / 2;
            int count = 0;
            double maxFraction = 0;
            int[] result = new int[2];
            int j = 1;

            for (int i = 0; i < n - 1; i++)
            {
                while (j < n && arr[i] > mid * arr[j])
                {
                    j++;
                }
                if (j == n) break;

                count += n - j;
                double fraction = (double)arr[i] / arr[j];
                if (fraction > maxFraction)
                {
                    maxFraction = fraction;
                    result[0] = arr[i];
                    result[1] = arr[j];
                }
            }

            if (count == k) return result;
            else if (count < k) low = mid;
            else high = mid;
        }

        return new int[0];
    }
}