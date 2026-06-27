public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    int ROWS,COLS;

    public void Solve(char[][] board) {
        ROWS = board.Length;
        COLS = board[0].Length;

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(board[r][c] == 'O' && (r == 0 || r == ROWS-1 || c == 0 || c == COLS-1)){
                    Dfs(r,c,board);
                }
            }
        } 

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(board[r][c] == 'O'){
                    board[r][c] = 'X';
                }
            }
        } 

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(board[r][c] == 'T'){
                    board[r][c] = 'O';
                }
            }
        }

        
    }

    private void Dfs(int r, int c, char[][] board){
          board[r][c] = 'T';
        foreach(var dir in directions){
            int nr = r + dir[0]; int nc = c + dir[1];
            if(nr < 0 || nc <0 || nr == ROWS || nc == COLS || board[nr][nc] != 'O') continue;          
            Dfs(nr,nc,board);
        }
    }
}
