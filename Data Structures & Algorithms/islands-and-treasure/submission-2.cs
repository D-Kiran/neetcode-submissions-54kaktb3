public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    private int ROWS,COLS;
    private  const int INF = 2147483647;
    private Queue<(int,int)> queue = new();
    private HashSet<(int,int)> visited = new();

    public void islandsAndTreasure(int[][] grid) {
        ROWS = grid.Length;
        COLS = grid[0].Length;

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(grid[r][c] == 0){
                    queue.Enqueue((r,c));
                    visited.Add((r,c));
                }

            }
        }

        int steps = 0;
        
        while(queue.Count > 0){
            int size = queue.Count;
            for(int i=0; i<size; i++){
                var (row,col) = queue.Dequeue();
                 grid[row][col] = steps;

                foreach(var dir in directions){
                    int nr = row + dir[0]; int nc = col + dir[1];
                    if(nr  < 0 || nc <0 || nr == ROWS || nc == COLS || visited.Contains((nr,nc)) || grid[nr][nc] == -1) continue;

                    queue.Enqueue((nr,nc));
                    visited.Add((nr,nc));
                }              
            }
            steps++;  
        }

    }

    
}
