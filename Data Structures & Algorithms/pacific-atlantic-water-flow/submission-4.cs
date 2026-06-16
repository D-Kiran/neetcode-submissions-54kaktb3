public class Solution {
    private int[][] directions = [[1,0],[-1,0],[0,1],[0,-1]];
    private int ROWS,COLS;

    public List<List<int>> PacificAtlantic(int[][] heights) {
         ROWS = heights.Length;
         COLS = heights[0].Length;

        HashSet<(int,int)> pvisited = new();
        HashSet<(int,int)> atvisited = new();

        for(int c=0; c<COLS; c++){
            Dfs(0,c,pvisited,heights);
            Dfs(ROWS-1,c,atvisited,heights);
        }
        for(int r=0; r<ROWS; r++){
            Dfs(r,0,pvisited,heights);
            Dfs(r,COLS-1,atvisited,heights);
        }

        List<List<int>> result = new();

        for(int r=0; r<ROWS;r++){
            for(int c=0; c<COLS; c++){
                if(pvisited.Contains((r,c)) && atvisited.Contains((r,c))){
                    result.Add(new List<int>{r,c});
                }
            }
        }

        return result;

    }

    private void Dfs(int r, int c, HashSet<(int,int)> visited, int[][] heights){
        visited.Add((r,c));
        foreach(var dir in directions){
            int nr = r+dir[0]; int nc = c + dir[1];

            if(nr<0 || nc <0 || nr == ROWS || nc == COLS || visited.Contains((nr,nc))
                || heights[nr][nc] < heights[r][c]) continue;

            Dfs(nr,nc,visited,heights);
        }
    }
}
