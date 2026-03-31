public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        Console.WriteLine(rows);
        int columns = matrix[0].Length;
         Console.WriteLine(columns);
        for(int i=0; i<rows;i++){
            for(int j=0; j<columns;j++){
                if(matrix[i][j] == target) return true;
            }
        }
        return false;
    }
}
