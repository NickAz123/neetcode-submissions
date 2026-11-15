public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        //Create dictionary of key number and value counter
        Dictionary<int, int> freq = new();
        int[] result = new int[k];

        //Loop through nums
        foreach(int num in nums){
            if(freq.ContainsKey(num)){
                freq[num] += 1;
            }else {
                freq[num] = 1;
            }
        }

        List<int> ordered = freq.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList();
        return ordered.ToArray();
    }
}
