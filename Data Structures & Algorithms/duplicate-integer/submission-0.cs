public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        //Create hashset(nums) empty
        //loop through the nums array 
        //if not found in hash, add to hash
        //if found, return true
        //Return true if values appear more than once
        //return false

        HashSet<int> seen = new();

        foreach(int num in nums){
            if(!seen.Contains(num)){
                seen.Add(num);
            } else {
                return true;
            }
        }

        return false;
    }
}