public class Solution {
    
    public bool ContainsDuplicate(int[] nums) {
            
            HashSet<int> hash = new HashSet<int>(nums);

            if (nums.Length != hash.Count)
            {
                return true;
            } 
        
          return false; 
       }
    
}