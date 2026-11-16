public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<int>> rows;
        Dictionary<int, HashSet<int>> cols = new();
        Dictionary<(int, int), HashSet<int>> squares = new Dictionary<(int, int), HashSet<int>>();

        for(int i = 0; i < board.Length; i++){

            rows = new();

            for(int j = 0; j < board[i].Length; j++){

                char num = board[i][j];

                //Empty check
                if(num == '.'){
                    continue;
                }

                //Column Check
                if(!cols.ContainsKey(j)){
                    cols[j] = new HashSet<int>{num};
                }
                else{
                    if(cols[j].Contains(num)){
                        return false;
                    } else {
                        cols[j].Add(num);
                    }
                }

                //RowCheck
                if(!rows.ContainsKey(i)){
                    rows[i] = new HashSet<int>{num};
                }
                else{
                    if(rows[i].Contains(num)){
                        return false;
                    } else{
                        rows[i].Add(num);
                    }
                }

                //square check
                (int val1, int val2) square = (i/3, j/3);

                if(!squares.ContainsKey(square)){
                    squares[square] = new HashSet<int>{num};
                } else {
                    if(squares[square].Contains(num)){
                        return false;
                    } else {
                        squares[square].Add(num);
                    }
                }
            }
        }

        return true;
    }   
}
