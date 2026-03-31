public class Solution {
    public int ShortestPath(int[][] grid) {
        if(grid[0][0] == 1) return -1;
        return Bfs(grid);
    }

    private int Bfs(int[][]grid){
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        var queue = new Queue<(int row, int col)>();
        var visit = new HashSet<(int row,int col)>();
        queue.Enqueue((0,0));
        visit.Add((0,0));
        int length=0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            for(int i=0; i<size; i++){
                var (r,c) = queue.Dequeue();
               if(r == ROWS-1 && c== COLS-1) return length;

                var neighbours = new (int dr, int dc)[]  {
                  (0,1), (0,-1), (1,0), (-1,0)
                };

               foreach(var (dr,dc) in neighbours)
               {
                   var nr = r+dr; var nc = c+dc;
                   if(Math.Min(nr,nc) < 0 || nr == ROWS || nc == COLS || 
                   visit.Contains((nr,nc)) || grid[nr][nc] == 1  )

                    continue;
                   queue.Enqueue((nr,nc));
                   visit.Add((nr,nc));
                }
            }
            length++; 
        }
        if(queue.Count == 0) return -1;
        var result = length == 0? -1 : length;
        return result;

    }
}
