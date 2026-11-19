public class Solution {
    public int Trap(int[] height) {
        //Setup double pointers
        //Setup accumulated value

        int left = 0;
        int right = left + 1;
        int total = 0;
        int between = 0;
        int arrLength = height.Length -1;

        while(right < arrLength){

            while(right < arrLength && height[left] <= height[right]){
                left++;
                right++;
            }

            while(right < arrLength && height[left] > height[right]){
                between += height[right];
                right++;
            }

            if(height[left] <= height[right]){
                total += (right - left - 1) * Math.Min(height[left], height[right]) - between;
                between = 0;
                left = right;
                right += 1;
            } else {

                int boundary = left;
                left = right - 1;
                between = 0;

                while(left >= boundary){

                    while(left >= boundary && height[left] >= height[right]){
                        left--;
                        right--;
                    }

                    while(left >= boundary && height[left] < height[right]){
                        between += height[left];
                        left--;
                    }

                    if(left >= boundary && height[left] >= height[right]){
                        total += (right - left - 1) * Math.Min(height[left], height[right]) - between;
                        between = 0;
                        right = left;
                        left -= 1;
                    }
                }

                break;

            }
            
        }

        return total;
    }
}
