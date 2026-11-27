public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int[] result = new int[arr.Length];

        for(int i = 0; i < arr.Length; i++){
            int j = i + 1;
            int max = 0;
            
            while(j < arr.Length){
                if(arr[j] > max){
                    max = arr[j];
                }
                j++;
            }

            result[i] = max;
        }

        result[arr.Length - 1] = -1;

        return result;
    }
}