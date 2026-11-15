public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //create a loop in a loop, creation of two counters going upward
        for(int i = 0; i < nums.Length - 1; i++){
            int comp = target - nums[i];
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[j] == comp){
                    return [i, j];
                }
            }
        }

        return new int[2];
    }
}
