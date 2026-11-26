public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int max = 0;

        if(s.Length == 1){
            return 1;
        }

        HashSet<int> seen = new();

        while(right < s.Length){
            if(!seen.Contains(s[right])){
                seen.Add(s[right]);
                right++;
            } else {
                max = Math.Max(max, right - left);

                while(s[left] != s[right]){
                    seen.Remove(s[left]);
                    left++;
                }
                left++;
                right++;
            }
        }

        return Math.Max(max, right - left);
    }
}
