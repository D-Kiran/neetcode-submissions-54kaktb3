public class Solution {
    public int CountPaths(int[][] grid) {
       return dfs(grid, 0, 0, new int[grid.Length,grid[0].Length]);
    }

    private int dfs(int[][]grid, int r, int c, int[,]visit){
        int ROWS = grid.Length; int COLUMNS = grid[0].Length;

        if(Math.Min(r,c)<0 || r == ROWS || c == COLUMNS || visit[r,c]==1 || grid[r][c]==1 ){
            return 0;
        }
        if(r == ROWS-1 && c == COLUMNS-1 ){
            return 1;
        }

        visit[r,c]=1;

        int count = 0;
        count += dfs(grid,r+1,c,visit);
        count += dfs(grid,r-1,c,visit);
        count += dfs(grid,r, c+1, visit);
        count += dfs(grid, r, c-1, visit);

        visit[r,c]=0;
        return count;

    }
}
