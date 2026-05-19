public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        
        int length = points.Length;
        PriorityQueue<int[], double> minheap = new();
        int[][] result = new int[k][];

        for(int i=0; i<length; i++){
            var point = points[i];
            var distance = Math.Sqrt(Math.Pow((point[0]-0),2) + Math.Pow((point[1]-0),2));
            minheap.Enqueue(point,distance);

            // if(minheap.Count > k){
            //     minheap.Dequeue();
            // }
        }

       int j=0;
       while(minheap.Count > 0){
          if(j == k) break;
          result[j] = minheap.Dequeue(); j++;
       }

       return result;
    }
}
