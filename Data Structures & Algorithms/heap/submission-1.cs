public class MinHeap {

    private List<int?> heap;
    private int N = 0;

    public MinHeap() {
        this.heap = new List<int?>();  
        heap.Add(0);
    }

    public void Push(int val) 
    {
        heap.Add(val);
        ++N;
        Swim(N);
    }

    public int? Pop() {
       // Console.WriteLine($"in pop");
        if(N == 0) return -1;
        var min = heap[1];
        Swap(1,N--);
        heap[N+1] = null;
        Sink(1);
        return min;
    }

    public int? Top() 
    {
        if(N == 0) return -1;
        return heap[1];
    }

    public void Heapify(List<int> nums) 
    {
        if(N == 0){
           heap = new List<int?>();
           heap.Add(0);
        }
       
        foreach(var num in nums){
            heap.Add(num);
            ++N;
        }
        for(int k = N/2; k>=1; k--){
            Sink(k);
        }
    }

    private void Swap(int i, int j)
    {
        var temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    private void Swim(int k)
    {
        while(k>1 && (heap[k] < heap[k/2]))
        {
            Swap(k,k/2);
            k=k/2;
        }
    }

    private void Sink(int k)
    {
        while(2*k <= N)
        {
            int j = 2*k;
            if(j < N && heap[j]>heap[j+1]) j++;
            if(heap[k] < heap[j]) break;
            Swap(k,j);
            k=j;
        }
    }

}