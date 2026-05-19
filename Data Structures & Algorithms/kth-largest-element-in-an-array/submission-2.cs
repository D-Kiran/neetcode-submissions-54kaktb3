public class Solution {
    public int FindKthLargest(int[] nums, int k) {

        PriorityQueue<int,int> minheap = new();

        foreach(var num in nums){
            minheap.Enqueue(num,num);
            if(minheap.Count > k){
                minheap.Dequeue();
            }
        }

        return minheap.Dequeue();
    }
}
