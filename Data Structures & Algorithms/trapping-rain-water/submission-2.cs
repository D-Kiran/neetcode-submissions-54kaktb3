public class Solution {
    public int Trap(int[] height) {
         
         //optimised run time approach and for space

         int n= height.Length;
         int result=0;

         int left =0; int right = n-1;

         int maxleft = -1; int maxright=-1;

         while(left < right){
            maxleft = Math.Max(height[left], maxleft);
            maxright = Math.Max(height[right], maxright);

            if(maxleft <= maxright){
                result += (maxleft - height[left]);
                left++;
            }
            else if(maxleft > maxright){
                result += (maxright - height[right]);
                right--;
            }
         }

         return result;
    }
}
