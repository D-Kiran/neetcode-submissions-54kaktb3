public class Solution {
    public int Trap(int[] height) {
         
         //optimised approach

         int n= height.Length;
         int result=0;

         int[] leftmax = new int[n];
         leftmax[0]=height[0];
         int[] rightmax = new int[n];
            rightmax[n-1]=height[n-1];

         for(int i=1; i<n;i++)
         {
            leftmax[i] = Math.Max(leftmax[i-1],height[i]);
         }

         for(int k=n-2; k>=0; k--){
            rightmax[k] = Math.Max(rightmax[k+1], height[k]);
         }

         for(int i=0 ; i<n; i++){
            int totalspaceforaposition = Math.Min(leftmax[i], rightmax[i]);
            int availablespace = totalspaceforaposition-height[i];
            result += availablespace;
         }
     
         return result;
    }
}
