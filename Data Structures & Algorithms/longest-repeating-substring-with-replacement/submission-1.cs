public class Solution {
    public int CharacterReplacement(string s, int k) {
        //declare dictionary 
        //go through s
        //add is if not exist in dictionary with a count of 1
        //if exist, increment counter
        //check window size - most frequent dictionary character
        //if valid, take length and compare to max

        Dictionary<char, int> freq = new();

        int left = 0;
        int right = 0;
        int max = 0;
        int valid = 0;

        while(right < s.Length){
            char rightc = s[right];

            if(!freq.ContainsKey(rightc)){
                freq[rightc] = 0;
            }
            
            int count = freq[rightc] + 1;
            freq[rightc] = count;
            
            int mostFreq = freq.OrderByDescending(x => x.Value).First().Value;
            valid = (right - left + 1) - mostFreq;
            
            if(valid <= k){
                max = Math.Max(max, valid);
            } else {
                while(valid > k){
                    int reduce = freq[s[left]] - 1;
            
                    freq[s[left]] = reduce;
                    left++;
                    valid = (left - right) - mostFreq;
                }
            }

            right++;
        }

        return Math.Max(max, right - left);
    }

}
