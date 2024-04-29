class Solution {
public:
    int minOperations(vector<int>& nums, int k) {
        int arrayXOR;
        for(int i=0; i<nums.size(); i++)
        {
            if(i == 0) arrayXOR = nums[i];
            else arrayXOR ^= nums[i];
        }

        arrayXOR ^= k;

        int cnt = 0;

        while(arrayXOR > 1)
        {
            if(arrayXOR % 2 == 1) cnt++;
            arrayXOR /= 2;
        }
        if(arrayXOR == 1) cnt++;
        return cnt;
    }
};
