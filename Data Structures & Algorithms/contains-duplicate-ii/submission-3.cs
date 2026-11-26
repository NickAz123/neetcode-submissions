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
            Console.WriteLine("index r" + right);
            int numsr = nums[right];
            
            if(!seen.Contains(numsr)){
                Console.WriteLine("adding " + numsr + " to the Hash");
                seen.Add(numsr);
            } else {
                
                while(nums[left] != numsr){
                    left++;
                }

                Console.WriteLine("found match " + nums[left] + " | " + numsr);

                Console.WriteLine(right + "|" + left);

                inRange = (right - left) <= k;

                left++;
            }

            right++;
        }

        return inRange;
    }
}