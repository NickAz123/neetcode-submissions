public class Solution {
    public int CharacterReplacement(string s, int k) {

        int[] freq = new int[26];
        int left = 0;
        int maxFreq = 0;
        int window = 0;

        for(int right = 0; right < s.Length; right++){
            int count = ++freq[s[right] - 'A'];
            maxFreq = Math.Max(maxFreq, count);
            
            while((right - left + 1)  - maxFreq > k){
                freq[s[left] - 'A']--;
                left++;
            }

            window = Math.Max(window, right - left + 1);
        }

        return window;

    }

}
