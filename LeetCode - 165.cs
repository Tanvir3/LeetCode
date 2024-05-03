public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        int temp = 0;
        Queue<int> q = new Queue<int>();
        Queue<int> q1 = new Queue<int>();

        for (int i = 0; i < version1.Length; i++)
        {
            if (version1[i] == '.')
            {
                q.Enqueue(temp);
                temp = 0;
            }
            else temp = (temp * 10) + (version1[i] - '0');
        }

        q.Enqueue(temp);
        temp = 0;

        for (int i = 0; i < version2.Length; i++)
        {
            if (version2[i] == '.')
            {
                q1.Enqueue(temp);
                temp = 0;
            }
            else temp = (temp * 10) + (version2[i] - '0');
        }

        q1.Enqueue(temp);
        int answer = 0;
        int sz = Math.Max(q.Count, q1.Count);

        for (int i = 0; i < sz; i++)
        {
            if (q.Peek() < q1.Peek())
            {
                answer = -1;
                break;
            }
            if (q.Peek() > q1.Peek())
            {
                answer = 1;
                break;
            }
            q.Dequeue();
            q1.Dequeue();

            if (q.Count == 0) q.Enqueue(0);
            if (q1.Count == 0) q1.Enqueue(0);
        }

        return answer;
    }
}