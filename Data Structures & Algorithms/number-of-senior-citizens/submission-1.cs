public class Solution {
    public int CountSeniors(string[] details) {
        int counter = 0;

        for(int i = 0; i < details.Length; i++){
            int num = int.Parse(details[i][11] + "" + details[i][12]);

            if(num > 60){
                counter++;
            }
        }

        return counter;
    }
}