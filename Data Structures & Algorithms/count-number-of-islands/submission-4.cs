public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    private int ROWS, COLS;

    public int NumIslands(char[][] grid) {
        ROWS = grid.Length;
        COLS = grid[0].Length;
       int steps = 0;

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(grid[r][c] == '1'){
                    Dfs(r,c,grid);
                    steps++;
                }
            }
        }

        return steps;
    }

    private void Dfs(int r, int c, char[][]grid){
        if(r < 0 || c<0 || r == ROWS || c == COLS || grid[r][c] == '0') return;

        grid[r][c] = '0';

        foreach(var dir in directions){
            int nr = r + dir[0]; int nc = c+dir[1];

            Dfs(nr,nc,grid);
        }
    }
}
