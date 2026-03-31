public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        int rolo=0; int rohi=rows-1;
        int targetro = 0;
         while(rolo<=rohi)
           {
                int mid= rolo+((rohi-rolo)/2);
                if(matrix[mid][0] <= target && target <=matrix[mid][columns-1] ){
                   targetro = mid;
                   break;
                }
                else if(matrix[mid][0] > target){
                    rohi=mid-1;
                }
                else{
                    rolo = mid+1; 
                }
            }
            Console.WriteLine(targetro);

        //for(int i=0;i<rows;i++){
            int lo=0; int hi=columns-1;
            while(lo<=hi){
                int mid= lo+((hi-lo)/2);
                if(matrix[targetro][mid] < target){
                    lo = mid+1;
                }
                else if(matrix[targetro][mid] > target){
                    hi=mid-1;
                }
                else{
                    return true;
                }
            }
      //  }
        return false;
    }
}
