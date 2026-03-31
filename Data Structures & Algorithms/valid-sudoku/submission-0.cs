public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int ROWS = 9;
        int COLS = 9;

        //row iterations
        for(int r=0; r<ROWS; r++){
            var set = new HashSet<char>();
            for(int c=0; c<COLS; c++){
                var ch = board[r][c];
                if(ch == '.') continue;
                if(set.Contains(ch)) return false;
                set.Add(ch);
            }
        }

        //column iteration

        for(int c=0; c<COLS; c++){
            var set = new HashSet<char>();
           for(int r=0; r<ROWS; r++)
            {
                var ch = board[r][c];
                if(ch == '.') continue;
                if(set.Contains(ch)) return false;
                set.Add(ch);               
            }
        }

        //3*3 box iteration
        for(int square =0; square <9; square++){
            var set = new HashSet<char>();
            for(int i=0; i<3;i++){
                for(int j=0; j<3; j++){
                    int r = (square/3)*3 + i;
                    int c = (square%3)*3 +j;
                    var ch = board[r][c];
                    if(ch == '.') continue;
                    if(set.Contains(ch)) return false;
                     set.Add(ch);
                }
            }
        }

        return true;
       



    }
}
