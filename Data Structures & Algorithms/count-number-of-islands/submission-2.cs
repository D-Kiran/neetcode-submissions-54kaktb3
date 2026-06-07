public class Solution {
    public int NumIslands(char[][] grid) {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        HashSet<(int row, int col)> visited = new();
        int result =0;

        for(int r = 0; r<ROWS; r++){
            for(int c=0; c<COLS; c++){
                if(grid[r][c] == '1' && !visited.Contains((r,c))){
                    Dfs(grid, r, c, visited);
                    result++;
                }
            }
        }

        return result;
    }

    private void Bfs(char[][] grid, int r, int c, HashSet<(int row,int col)> visited){
        Queue<(int ro, int co)> queue = new();
        int ROWS = grid.Length; 
        int COLS = grid[0].Length;
        int[][] directions = [[1,0],[-1,0],[0,1],[0,-1]] ;

        queue.Enqueue((r,c));
        visited.Add((r,c));

        while(queue.Count > 0){
            var (roo, cool) = queue.Dequeue();

            foreach(var direction in directions){
                int nr = roo + direction[0]; int nc = cool + direction[1];

                if(nr < 0 || nc <0 || nr==ROWS || nc == COLS || grid[nr][nc] != '1' || visited.Contains((nr,nc))) continue;
                queue.Enqueue((nr,nc));
                visited.Add((nr,nc));
            }
        }
    }

    private void Dfs(char[][] grid, int r, int c, HashSet<(int row,int col)> visited){
        Stack<(int ro, int co)> stack = new();
        int ROWS = grid.Length; 
        int COLS = grid[0].Length;
        int[][] directions = [[1,0],[-1,0],[0,1],[0,-1]] ;

        stack.Push((r,c));
        visited.Add((r,c));

        while(stack.Count > 0){
            var (roo, cool) = stack.Pop();

            foreach(var direction in directions){
                int nr = roo + direction[0]; int nc = cool + direction[1];

                if(nr < 0 || nc <0 || nr==ROWS || nc == COLS || grid[nr][nc] != '1' || visited.Contains((nr,nc))) continue;
                stack.Push((nr,nc));
                visited.Add((nr,nc));
            }
        }
    }
}
