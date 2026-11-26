public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        //Size the window pointers
        //State the current operations
        //start pointers along the string 
        //find first minimum

        //loop throgh while right < blocks.Length
        //inner loop for the window, count the W's
        //take the minimum operation

        int left = 0;
        int right = k - 1;
        int? min = null;

        while(right < blocks.Length){
            
            int conversions = 0;
            for(int i = left; i <= right; i++){
                
                if(blocks[i] == 'W'){
                    conversions++;
                }
            }

            if(min == null){
                min = conversions;
            } else {
                min = Math.Min(min.Value, conversions);
            }

            right++;
            left++;
        }
        
        return min.Value;
    }
}