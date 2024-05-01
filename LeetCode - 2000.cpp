class Solution {
public:
    string reversePrefix(string word, char ch) {
        bool solution = false;
        string answer = "";
        int pos = 0;

        for(int i=0; i<word.size(); i++)
        {
            if(word[i] == ch)
            {
                solution = true;
                pos = i;
                break;
            }
        }

        if(solution)
        {
            for(int i=pos; i>=0; i--) answer += word[i];
            for(int i=pos+1; i<word.size(); i++) answer += word[i];
            return answer;
        }
        else return word;
    }
};
