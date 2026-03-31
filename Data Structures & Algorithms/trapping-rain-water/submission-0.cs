public class Solution {
    public int Trap(int[] height) {
         
         //brute force

         int n= height.Length;
         int result=0;
         for(int i=0; i<n; i++)
         {
            int leftmax = height[i];
            int rightmax = height[i];

            for(int j=0; j<i; j++){
                leftmax = Math.Max(height[j], leftmax);
            }

            for(int k=i+1; k<n ;k++){
                rightmax = Math.Max(height[k],rightmax);
            }
            result += (Math.Min(leftmax,rightmax) - height[i]);

         }

         return result;
    }
}
