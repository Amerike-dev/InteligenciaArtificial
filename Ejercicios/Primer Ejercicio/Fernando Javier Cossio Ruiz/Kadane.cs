public class Kadane {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int current = max; 
        for (int i =1; i< nums.Length; i++){
            current = Math.Max(nums[i] + current, nums[i]);
            max = Math.Max(current, max);
        }
        return max;
    }
}