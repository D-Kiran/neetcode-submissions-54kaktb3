public class Solution {
    public int OrangesRotting(int[][] grid) {
        int[][] directions = [[1,0],[-1,0],[0,1],[0,-1]];

        Queue<(int,int)> queue = new();

        int fresh = 0;
        int time =0;

        for(int r= 0; r<grid.Length; r++){
            for(int c=0 ;c<grid[0].Length;c++){
                if(grid[r][c] == 1) fresh++;
                if(grid[r][c] == 2) queue.Enqueue((r,c));
            }
        }

        while(fresh >0 && queue.Count > 0){
            int size = queue.Count;

            for(int i=0; i<size; i++){
                var (row,col) = queue.Dequeue();
                
                foreach(var dir in directions){
                    int nr = row + dir[0]; int nc = col + dir[1];

                    if(nr < 0 || nc <0 || nr == grid.Length || nc == grid[0].Length || grid[nr][nc] == 0) continue;

                    if(grid[nr][nc] == 1){
                        grid[nr][nc] = 2;
                        queue.Enqueue((nr,nc));
                        fresh--;
                    }
                }
            }
            time++;
        }

        return fresh == 0? time : -1;
    }
}
