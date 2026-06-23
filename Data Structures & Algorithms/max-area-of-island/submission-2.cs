public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    private int ROWS,COLS;

    public int MaxAreaOfIsland(int[][] grid) {
        ROWS = grid.Length;
        COLS = grid[0].Length;
        int area = 0;

        for(int r=0; r<ROWS; r++){
            for(int c=0 ;c<COLS; c++){
                if(grid[r][c] == 1){
                    area = Math.Max(area, Dfs(r,c,grid));
                }
            }
        }

        return area;
    }

    private int Dfs(int r, int c, int[][] grid){
        if(r < 0 || c <0 || r == ROWS || c== COLS || grid[r][c] == 0) return 0;

        grid[r][c] = 0;

       return 1 + Dfs(r -1 ,c,grid) + Dfs(r+1,c,grid)+Dfs(r, c-1,grid)+Dfs(r,c+1,grid);
    }
}
