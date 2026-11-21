public class Solution {
    public int LargestRectangleArea(int[] heights) {
        //create a stack of two ints
        Stack<(int index, int height)> bars = new();
        int max = 0;
        //go through heights

        for(int i = 0; i < heights.Length; i++){

            int height = heights[i];
            if(bars.Count == 0 || height >= bars.Peek().height){
                bars.Push((i, height));
                continue;
            }

            int newIndex = 0;
            while(bars.Count > 0 && height < bars.Peek().height){
                var poppedVal = bars.Pop();
                int area = poppedVal.height * (i - poppedVal.index);

                if(area > max){
                    max = area;
                }
                newIndex = poppedVal.index;
            }

            bars.Push((newIndex, height));
        }

        while(bars.Count > 0){
            var poppedVal = bars.Pop();
            int area = (heights.Length - poppedVal.index) * poppedVal.height;
            
            if(area > max){
                max = area;
            }
        }
        return max;
    }

}
