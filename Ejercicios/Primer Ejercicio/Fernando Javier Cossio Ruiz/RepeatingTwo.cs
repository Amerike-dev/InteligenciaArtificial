public class Solution {
    public bool ContainsDuplicate(int[] nums) {
     HashSet<int> myHash = new HashSet <int> (nums);

        if (nums.Length == myHash.Count){
            return false;
        } else return true;
    }
}