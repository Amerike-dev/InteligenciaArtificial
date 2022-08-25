public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int temp = nums[0];
        for(int i = 0; i < nums.Length; i++ ){
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] != nums[j]){
                    continue;
                } else {
                    return true;
                }
            }
        }
        return false;
    }
}