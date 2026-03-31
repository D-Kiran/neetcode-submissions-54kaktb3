public class Solution {
    public int MaxArea(int[] heights) 
    {   
       //optimised

       int left = 0; int right = heights.Length-1;
        int area = 0;

       while(left < right){
          int leftHeight = heights[left];
          int rightHeight = heights[right];
          int height = Math.Min(leftHeight,rightHeight);
          int width = right-left;

          area= Math.Max(height*width, area);

          if(leftHeight<=rightHeight) left++;
          if(rightHeight < leftHeight) right--;
       }

       return area;
    }
}
