public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var maxHeap = new PriorityQueue<int,int>();

        foreach(var num in nums){
            maxHeap.Enqueue(num,-num);
        }

        for(int i=1; i<k; i++){
            maxHeap.Dequeue();
        }
        return maxHeap.Peek();
    }
}
