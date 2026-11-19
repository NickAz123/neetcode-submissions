public class Solution {
    public bool IsValid(string s) {
        //create a dictionary to store pairs of parenthesis
        //Create an empty stack to store pairs that need to be closed
        //iterate through s 
        //in On complexity with On space
        Dictionary<char, char> pairs = new Dictionary<char, char>{
            {'(' , ')'},
            {'{' , '}'},
            {'[', ']'}
        };

        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            
            if(pairs.ContainsKey(c)){
                stack.Push(pairs[c]);
            } else {
                
                if(stack.Count > 0 && stack.Peek() == c){
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }

        if(stack.Count > 0){
            return false;
        }

        return true;
    }
}
