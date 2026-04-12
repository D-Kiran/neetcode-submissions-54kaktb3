public class Solution {
    public int LargestRectangleArea(int[] heights) {
        
        int area =0;
        int n = heights.Length;
        for(int i=0; i<n ;i++){
            int currentheight = heights[i];

            int left = i; int right= i+1;

            while(right < n && heights[right] >= currentheight){
                right++;
            }

            while(left >=0 && heights[left] >= currentheight){
                left--;
            }

            right--;
            left++;

            area = Math.Max(area, currentheight*(right-left+1));

        }

        return area;
    }
}
