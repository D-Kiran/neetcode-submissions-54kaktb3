public class Solution {
    public int MaxArea(int[] heights) 
    {   
       //brute force
        int max = Int32.MinValue;
       for(int i=0; i<heights.Length; i++){
          for(int j=i+1; j<heights.Length; j++){
            int height = Math.Min(heights[i], heights[j]);
            int width = j-i;
            max = Math.Max(height*width, max);
          }
       }

       return max;
    }
}
