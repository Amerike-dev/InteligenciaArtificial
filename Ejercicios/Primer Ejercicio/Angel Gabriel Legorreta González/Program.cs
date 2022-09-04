public class Solution {
    public bool ContainsDuplicate(int[] nums) {
          if (nums == null || nums.Length == 0) return true;
   
   int l = nums.Length;
   for (int i=1; i<l; i++) {
      if (nums[i-1] == nums[i]) {
         return false;
      }
   }
    return true;
}
     
}