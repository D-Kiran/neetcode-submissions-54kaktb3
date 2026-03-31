public class Solution {
    public int[][] KClosest(int[][] points, int k) {
       var minHeap = new PriorityQueue<int[],double>();
        var output = new int[k][];

        for(int i=0; i<k; i++){
            output[i] = new int[2];
        }
       int rows = points.Length;
       for(int r =0; r<rows;r++)
       {
          int x = points[r][0];
          int y = points[r][1];
          var distance = Distance((double)x, (double)y);
          minHeap.Enqueue(new int[2]{x,y},distance);
       }
        int count = 0;
       while(count < k){
         output[count] = minHeap.Dequeue();
         count++;
       }

       return output;
    }

    private static double Distance(double x, double y){
        var dis = Math.Sqrt((x*x) + (y*y));
        return dis;
    }
}
