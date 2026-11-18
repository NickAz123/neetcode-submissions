public class Solution {
    public bool IsPalindrome(string s) {
        //remove whitespace from string
        //create a two index loop from the left and the right
        // as you iterate compare the values, and if they dont equal return false
        //return true at end of method

        string nospace = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

        int left = 0;
        int right = nospace.Length - 1;

        while(left <= right){
            if (nospace[left] != nospace[right]){
                return false;
            }

            left++;
            right--;
        }
        return true;
    }
}
