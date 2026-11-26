public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);

        int left = 0;
        int right = left + k - 1;
        int min = Math.Abs(nums[right] - nums[left]);

        while(right < nums.Length){
            min = Math.Min(min, nums[right] - nums[left]);
            right++;
            left++;
        }

        return min;
    }
}