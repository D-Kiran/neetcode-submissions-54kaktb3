public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        HashSet<(int row,int col)> visited = new();
        int area = 0;
        for(int r =0; r<grid.Length; r++){
            for(int c=0; c<grid[0].Length; c++){
                Console.WriteLine($"roe col");
                if(grid[r][c] == 1 && !visited.Contains((r,c))){
                    Console.WriteLine($"in if condition : ");
                    var result = Bfs(grid,r,c,visited);
                    Console.WriteLine($"result : {result}");
                    area = Math.Max(result,area);
                }              
            }
        }

        return area;
    }

    private int Bfs(int[][] grid, int r, int c,HashSet<(int row,int col)> visited){
        int area = 0;
        Queue<(int ro,int co)> queue = new();
        int[][] directions = [[1,0],[-1,0],[0,1],[0,-1]];
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        queue.Enqueue((r,c));
        visited.Add((r,c));
        area=1;

        while(queue.Count > 0){
            var (roo, cool) = queue.Dequeue();

            foreach(var dir in  directions){
                int nr = roo + dir[0]; int nc = cool + dir[1];

                if(nr <0 || nc <0 || nr == ROWS || nc == COLS || grid[nr][nc] != 1 || visited.Contains((nr,nc))) continue;
                queue.Enqueue((nr,nc));
                visited.Add((nr,nc));
                area++;
            }
        }

        return area;
    }
}
