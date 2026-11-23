public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        if(s.Length == 0){
            return 0;
        }

        int result = 0;
        int i = 0;
        int j = 0;
        HashSet<int> seen = new();

        while(j < s.Length){
            int num = s[j];
            if(!seen.Contains(num)){
                seen.Add(num);
                j++;
            }else{
                result = Math.Max(j - i, result);
                while(s[i] != num){
                    seen.Remove(s[i]);
                    i++;
                }
                i++;
                Math.Max(j - i, result);
                j++;
            }
        }

        Console.WriteLine(result + "|" + seen.Count);

        return Math.Max(result, seen.Count);

    }
}
