class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int maxSoFar = 0;
        int maxEnding = 0;

        for (int i = 0; i < nums.length; i++)
        {
            maxEnding =  maxEnding + nums[i];

            if (maxEnding < 0)
            {
                maxEnding = 0;
            }
            
            if (maxSoFar < maxEnding)
            {
                maxSoFar = maxEnding;
            }
        }
        
        return maxSoFar;
    }
};