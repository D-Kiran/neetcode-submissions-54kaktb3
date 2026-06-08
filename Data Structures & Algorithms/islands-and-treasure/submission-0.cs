public class Solution {
    private int[][] directions = [[1,0],[0,1],[-1,0],[0,-1]];
    private int INF = int.MaxValue;
    private int ROWS,COLS;
   private HashSet<(int r, int c)> visited;

    public void islandsAndTreasure(int[][] grid) {
        ROWS = grid.Length;
        COLS = grid[0].Length;

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(grid[r][c] == INF  ){ //why not add visited?
                   grid[r][c] = Bfs(grid,r,c);
                }
            }
        }

       
    }

    private int Bfs(int[][] grid, int r, int c){
        Queue<(int r, int c)> queue = new();
        visited = new();
        queue.Enqueue((r,c));
        visited.Add((r,c));
        int steps =0;

        while(queue.Count > 0){
            int size = queue.Count;

            for(int i=0; i<size; i++){
                var (row,col) = queue.Dequeue();

                if(grid[row][col] == 0) return steps;
                
                foreach(var dir in directions){
                    int nr = row + dir[0]; int nc = col + dir[1];

                    if(nr < 0 || nc <0 || nr == ROWS || nc == COLS || grid[nr][nc] == -1 || visited.Contains((nr,nc))) continue;
                    queue.Enqueue((nr,nc));
                    visited.Add((nr,nc));
                }
            }
            steps++;
        }

        return INF;

        
    }
}
