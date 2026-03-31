public class KthLargest {

    private PriorityQueue<int,int> pq;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.pq = new PriorityQueue<int,int>();
        this.k=k;

        foreach(var num in nums){
            pq.Enqueue(num,num);
        }

        while(pq.Count > k)
        {
            pq.Dequeue();        
        }
    }
    
    public int Add(int val) 
    {
        pq.Enqueue(val,val);
        if(pq.Count > k){
            pq.Dequeue();
        }
        return pq.Peek();
    }
}
