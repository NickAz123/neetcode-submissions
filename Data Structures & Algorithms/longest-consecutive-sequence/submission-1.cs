public class Solution {
    public int LongestConsecutive(int[] nums) {

        int result = 0;

        HashSet<int> hash = new HashSet<int>(nums);

        for(int i = 0; i < nums.Length; i++){
            int num = nums[i];
            if(!hash.Contains(num - 1)){
                int counter = 1;

                while(hash.Contains(num +  1)){
                    counter ++;
                    num += 1; 
                }

                if(counter > result){
                    result = counter;
                }
            }
        }

        return result; 

    }
}