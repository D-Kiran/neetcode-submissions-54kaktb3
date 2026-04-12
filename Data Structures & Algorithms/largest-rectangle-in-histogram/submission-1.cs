public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int[]>();
        int n = heights.Length;
        int area =0;

        for(int i=0; i<n; i++){
            int currentidx = i; 
            int currentheight = heights[i];
            int adjustedidx = i;

            while(stack.Count > 0 && stack.Peek()[1] > currentheight){
                var cantextendpair = stack.Pop();
                area = Math.Max(area, cantextendpair[1] *(currentidx - cantextendpair[0]));
                adjustedidx = cantextendpair[0];
            }

            stack.Push(new int[2]{adjustedidx, currentheight});
        }

        foreach(var pair in stack){
            area = Math.Max(area, pair[1]* (n - pair[0]));
        }

        return area;
    }
}
