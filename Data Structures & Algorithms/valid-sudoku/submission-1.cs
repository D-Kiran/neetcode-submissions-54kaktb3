public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
       var rowdict = new Dictionary<int, HashSet<char>>();
       var coldict = new Dictionary<int, HashSet<char>>();
       var squaredict = new Dictionary<string, HashSet<char>>();

        for(int r=0; r<9; r++){
            for(int c=0; c<9; c++){
                var ch = board[r][c];
                if(ch == '.') continue;
                string squarekey = r/3 + "," + c/3;
                if(rowdict.ContainsKey(r) && rowdict[r].Contains(ch) ||
                    coldict.ContainsKey(c) && coldict[c].Contains(ch) ||
                    squaredict.ContainsKey(squarekey) && squaredict[squarekey].Contains(ch)) return false;
                
                if(!rowdict.ContainsKey(r)) rowdict[r]= new HashSet<char>();
                if(!coldict.ContainsKey(c)) coldict[c] = new HashSet<char>();
                if(!squaredict.ContainsKey(squarekey))  squaredict[squarekey] = new HashSet<char>();

                rowdict[r].Add(ch);
                coldict[c].Add(ch);
                squaredict[squarekey].Add(ch);

                
            }
        }

        return true;


    }
}
