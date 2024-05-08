class Solution {
public:
    vector<string> findRelativeRanks(vector<int>& score) {
        map<int, int> mp;
        vector<string> answer(score.size());
        for(int i=0; i<score.size(); i++) mp[score[i]] = i;

        sort(score.rbegin(),score.rend());

        for(int i=0; i<score.size(); i++)
        {
            if(i == 0) answer[mp[score[i]]] = "Gold Medal";
            else if(i == 1) answer[mp[score[i]]] = "Silver Medal";
            else if(i == 2) answer[mp[score[i]]] = "Bronze Medal";
            else answer[mp[score[i]]] = to_string(i+1);
        }

        return answer;
    }
};
