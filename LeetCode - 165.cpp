class Solution {
public:
    int compareVersion(string version1, string version2) {
        int temp = 0;
        queue<int> q;
        queue<int> q1;

        for(int i=0; i<version1.size(); i++)
        {
            if(version1[i] == '.')
            {
                q.push(temp);
                temp = 0;
            }
            else temp = (temp * 10) + (version1[i] - '0');
        }

        q.push(temp);
        temp = 0;

        for(int i=0; i<version2.size(); i++)
        {
            if(version2[i] == '.')
            {
                q1.push(temp);
                temp = 0;
            }
            else temp = (temp * 10) + (version2[i] - '0');
        }

        q1.push(temp);
        int answer = 0;
        int sz = max(q.size(), q1.size());

        for(int i=0; i<sz; i++)
        {
            if(q.front() < q1.front())
            {
                answer = -1;
                break;
            }
            if(q.front() > q1.front())
            {
                answer = 1;
                break;
            }
            q.pop();
            q1.pop();

            if(q.size() == 0) q.push(0);
            if(q1.size() == 0) q1.push(0);
        }

        return answer;
    }
};
