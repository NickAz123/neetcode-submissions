public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new();
        int[] results = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){
            
            if(i == 0){
                stack.Push(i);
                continue;
            }

            while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]){
                int prev = stack.Pop();
                results[prev] = i - prev;
            }

            stack.Push(i);

        }

        return results;
    }
}
