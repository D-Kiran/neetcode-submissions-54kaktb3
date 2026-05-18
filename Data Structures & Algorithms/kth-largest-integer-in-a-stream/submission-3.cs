public class KthLargest {

    private PriorityQueue<int,int> minheap = new();
    int k = 0;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        
        foreach(var num in nums){
            minheap.Enqueue(num,num);
            if(minheap.Count > k){
                minheap.Dequeue();
            }
        } 
    }
    
    public int Add(int val) {
        
        minheap.Enqueue(val,val);
        if(minheap.Count > k)
        {
            minheap.Dequeue();
        }
        return minheap.Peek();
    }
}
