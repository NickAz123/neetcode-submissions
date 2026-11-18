public class Solution {
    public int MaxArea(int[] heights) {

        int left = 0;
        int right = heights.Length - 1;
        int capacity = 0;

        while(left < right){
            int leftNum = heights[left];
            int rightNum = heights[right];
            int curVal = Math.Min(leftNum, rightNum) * (right - left);

            if(curVal > capacity){
                capacity = curVal;
            }

            if(leftNum < rightNum){
                left ++;
            } else {
                right --;
            }

        }

        return capacity;
    }
}
