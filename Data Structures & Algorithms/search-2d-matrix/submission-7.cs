public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int rowidx = 0; 
        
        for(int r=0; r<rows; r++){
            int first = matrix[r][0];
            int last = matrix[r][cols-1];

            if(first <= target && last >= target){
                 rowidx = r;
            }
        }

        int left = 0; int right = cols-1;

        while(left <= right)
        {
           int mid = left + (right-left/2);
           if(matrix[rowidx][mid] == target) return true;
           else if(matrix[rowidx][mid] < target) left = mid+1;
           else right = mid-1; 
        }

        return false;
    }
}
