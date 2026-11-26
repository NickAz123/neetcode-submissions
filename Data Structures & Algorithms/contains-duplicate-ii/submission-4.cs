public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        bool inRange = false;

        if(nums.Length < 2){
            return inRange;
        }

        int left = 0;
        int right = 0;
        HashSet<int> seen = new();

        while(right < nums.Length){
            int numsr = nums[right];
            
            if(!seen.Contains(numsr)){
                seen.Add(numsr);
            } else {
                
                while(nums[left] != numsr){
                    left++;
                }

                inRange = (right - left) <= k;

                left++;
            }

            right++;
        }

        return inRange;
    }
}