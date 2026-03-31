public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
      var minHeap = new PriorityQueue<int,int>();

      foreach(var stone in stones){
        minHeap.Enqueue(stone,-stone);
      }

      while(minHeap.Count>=2)
      {
        var x = minHeap.Dequeue();
        var y = minHeap.Dequeue();
        var diff = x-y;

        if(diff !=0)
        {
          minHeap.Enqueue(diff,-diff);
        }
      }

      if(minHeap.Count == 1) return minHeap.Dequeue();
      return 0;
      
    }
}
