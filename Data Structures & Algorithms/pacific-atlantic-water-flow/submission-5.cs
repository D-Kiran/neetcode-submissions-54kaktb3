public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    private HashSet<(int,int)> pacificVisited = new();
    private HashSet<(int,int)> atlanticVisited = new();
    int ROWS,COLS;

    public List<List<int>> PacificAtlantic(int[][] heights) {
        ROWS = heights.Length;
        COLS = heights[0].Length;
        List<List<int>> result = new();

        //first row and last row
        for(int c = 0; c<COLS; c++)
        { 
            Dfs(0,c,pacificVisited,heights); //top row close to pacific
            Dfs(ROWS-1,c,atlanticVisited,heights); //last row close to atlantic
        }


        //leftmost column and rightmost column
        for(int r=0; r<ROWS; r++)
        {
            Dfs(r,0,pacificVisited,heights); // left most column close to pacific
            Dfs(r,COLS-1,atlanticVisited, heights); //right most column close to atlantic
        }

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(pacificVisited.Contains((r,c)) &&  atlanticVisited.Contains((r,c))){
                    result.Add(new List<int>{r,c});
                }
            }
        }

        return result;
    }

    private void Dfs(int r, int c,HashSet<(int,int)> visited, int[][] heights){
        visited.Add((r,c));

        foreach(var dir in directions)
        {   
            int nr = r + dir[0]; int nc = c + dir[1];

            if(nr < 0 || nc<0 || nr == ROWS || nc== COLS || visited.Contains((nr,nc)) || heights[nr][nc] < heights[r][c]) continue;
            Dfs(nr,nc,visited,heights);
        }

        
    }
}
