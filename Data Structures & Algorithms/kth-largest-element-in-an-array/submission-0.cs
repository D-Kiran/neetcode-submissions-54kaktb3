public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var maxHeap = new PriorityQueue<int,int>();

        foreach(var num in nums){
            maxHeap.Enqueue(num,-num);
        }

        for(int i=0; i<k-1; i++){
            maxHeap.Dequeue();
        }
        return maxHeap.Peek();
    }
}
