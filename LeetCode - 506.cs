public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < score.Length; i++) map[score[i]] = i;

        Array.Sort(score);
        Array.Reverse(score);
        var result = new string[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            if (i == 0) result[map[score[i]]] = "Gold Medal";
            else if (i == 1) result[map[score[i]]] = "Silver Medal";
            else if (i == 2) result[map[score[i]]] = "Bronze Medal";
            else result[map[score[i]]] = (i + 1).ToString();
        }

        return result;
    }
}