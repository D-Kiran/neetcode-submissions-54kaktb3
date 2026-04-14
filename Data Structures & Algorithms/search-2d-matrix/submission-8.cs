public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        
        int top=0; int bottom = rows-1;

        while(top <= bottom){
            int mid = top + (bottom-top/2);
            var lastelementintherow = matrix[mid][cols-1];
            var firstelementinrow = matrix[mid][0];
            if( target > lastelementintherow ) top = mid+1;
            else if(target < firstelementinrow) bottom = mid-1;
            else break;
        }

        if(!(top <= bottom)) return false;

         int left = 0; int right = cols-1;
         int row = top + (bottom-top/2);

         while(left <= right){
            int mid = left + (right-left/2);
            var element = matrix[row][mid];

            if(element > target) right = mid-1;
            else if(element < target) left = mid+1;
            else return true;
         } 

         return false;
    }
}
