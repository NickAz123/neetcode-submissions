public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> results = new();
        
        for(int i = 0; i < nums.Length - 2; i++){
            
            if(i > 0 && nums[i - 1] == nums[i]){
                continue;
            }

            int cur = nums[i];
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right){
                int val = (nums[left] + nums[right] + nums[i]);
                if(val > 0){
                    right --;
                }else if(val < 0){
                    left ++;
                } else {
                    List<int> triplet = new List<int>{nums[i], nums[left], nums[right]};
                    results.Add(triplet);
                    
                    left++;
                    right--;

                    while(left < right && nums[left] == nums[left -1]){
                        left++;
                    }

                    while (left < right && nums[right] == nums[right+1]){
                        right--;

                    }
                }
            }
        }
        

        return results;
    }
}
