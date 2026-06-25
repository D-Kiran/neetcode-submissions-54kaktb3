public class Solution {
    private int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
    private int ROWS,COLS;
    private Queue<(int,int)> queue = new();

    public int OrangesRotting(int[][] grid) {
        ROWS = grid.Length;
        COLS = grid[0].Length;
        int minutes = 0;
        int fresh =0; 

        for(int r=0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(grid[r][c] == 1){
                    fresh ++;
                }
                else if(grid[r][c] == 2){
                    queue.Enqueue((r,c));
                }
            }
        }

        while(fresh >0 && queue.Count > 0){
            int size = queue.Count;
            for(int i=0; i<size; i++){
                var (row,col) = queue.Dequeue();

                foreach(var dir in directions){
                    int nr = row + dir[0]; int nc = col + dir[1];

                    if(nr < 0 || nc < 0 || nr == ROWS || nc == COLS || grid[nr][nc] == 0 || grid[nr][nc] == 2) continue;

                    grid[nr][nc] = 2;
                    fresh--;
                    queue.Enqueue((nr,nc));
                }
            }
            minutes ++;
        }

        

        return fresh == 0? minutes : -1;
    }
}
