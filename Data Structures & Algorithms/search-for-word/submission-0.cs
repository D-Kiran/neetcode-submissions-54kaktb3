public class Solution {
    public bool Exist(char[][] board, string word) {

        var set = new HashSet<(int,int)>();

        int ROWS = board.Length;
        int COLS = board[0].Length;

        bool Dfs(int row, int col, int idx){
            if(idx == word.Length) return true;

            if(row < 0 || col <0 ||
               row >= ROWS || col >= COLS ||
               word[idx] != board[row][col] ||
               set.Contains((row,col))
            ) return false;

            set.Add((row,col));

            var result = Dfs(row+1, col, idx+1) ||
                         Dfs(row-1, col, idx+1) ||
                         Dfs(row, col+1, idx+1) ||
                         Dfs(row, col-1, idx+1);

            set.Remove((row,col));

            return result;
        }

        for(int r = 0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(Dfs(r,c,0)) return true;
            }
        }

        return false;
    }
}
