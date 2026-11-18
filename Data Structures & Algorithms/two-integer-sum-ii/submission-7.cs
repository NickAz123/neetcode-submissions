public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //sort the array in place

        Array.Sort(numbers);

        int left = 0;
        int right = numbers.Length - 1;

        while(left < right){
            int total = numbers[left] + numbers[right]; 
            if(total > target){
                right--;
            }
            else if(total < target){
                left++;
            }else{
                return [left + 1,right + 1];
            }
        }

        return [];
    }
    
}
