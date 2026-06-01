public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        var result = new List<List<string>>();
        var board = new char[n][];
        for(int i=0; i<n;i++){
            board[i] = new string('.',n).ToCharArray();
        }

        HashSet<int> cols = new();
        HashSet<int> negDiag = new();
        HashSet<int> posDiag = new();


        void Backtrack(int row){
            if( row == n){
                var copy = new List<string>();
                foreach(char[] r in board){
                    copy.Add(new string(r));
                }

                result.Add(copy);
                return;
            }

            for(int c=0; c<n;c++){
                if(cols.Contains(c) || negDiag.Contains(row-c) || posDiag.Contains(row+c)){
                    continue;
                } 
                cols.Add(c);
                negDiag.Add(row-c);
                posDiag.Add(row+c);
                board[row][c] = 'Q';

                Backtrack(row+1);

                cols.Remove(c);
                negDiag.Remove(row-c);
                posDiag.Remove(row+c);
                board[row][c] = '.';
                  
            }          
        }

         Backtrack(0);
            return result;
            
    }


}
