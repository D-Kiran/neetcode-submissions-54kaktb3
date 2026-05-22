public class MedianFinder {

    private PriorityQueue<int,int> small; //maintain a max heap
    private PriorityQueue<int,int> large; //maintain a min heap


    public MedianFinder() {
        small = new();
        large = new();
    }
    
    public void AddNum(int num) {
        //insert into small first then we can filter out

        small.Enqueue(num, -num);

        if(small.Count > 0 && large.Count > 0){
            if(small.Peek() > large.Peek()){
                var element  = small.Dequeue();
                large.Enqueue(element,element);
            }
        }

        //make sure that the sizes differ maximum by 1

        if(small.Count > large.Count + 1){
            var element = small.Dequeue();
            large.Enqueue(element,element);
        }
        else if(large.Count  > small.Count + 1){
            var element = large.Dequeue();
            small.Enqueue(element,-element);
        }
    }
    
    public double FindMedian() {
        if(small.Count > large.Count ){
            return (double)small.Peek();
        }
        else if(large.Count > small.Count){
            return (double)large.Peek();
        }
        else{
            return ((small.Peek() + large.Peek())/2.0);
        }

    }
}
