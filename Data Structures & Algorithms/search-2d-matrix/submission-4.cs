public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        for(int i=0;i<rows;i++){
            int lo=0; int hi=columns-1;
            while(lo<=hi){
                int mid= lo+((hi-lo)/2);
                if(matrix[i][mid] < target){
                    lo = mid+1;
                }
                else if(matrix[i][mid] > target){
                    hi=mid-1;
                }
                else{
                    return true;
                }
            }
        }
        return false;
    }
}
