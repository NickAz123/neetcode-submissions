public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        //Create a dictionary (key = ordered string, value List<string>)
        //Create emtpy list of list<strings>
        Dictionary<string, List<string>> groups = new();
        List<List<string>> result = new();

        //Loop through strings
        foreach(string word in strs){
            char[] characters = word.ToCharArray();
            Array.Sort(characters);
            string ordered = new string(characters);
            //if(found in dictionary), add to the value list
            if(groups.ContainsKey(ordered)){
                groups[ordered].Add(word);
            } else {
                groups[ordered] = new List<string>{word};
            }

        }

        foreach(var (key, value) in groups){
            result.Add(groups[key]);
        }
        //add value to list<strings>
        
        //return the list of grouped strings
        return result;
    }
}
