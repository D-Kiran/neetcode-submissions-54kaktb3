public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
       var pq1 = new PriorityQueue<int,int>();
        var stack = new Stack<int>();

        foreach(var stone in stones)
        {
            pq1.Enqueue(stone,stone);
        }

        while(true)
        {
            if(pq1.Count == 0 || pq1.Count == 1) break;
            while(pq1.Count > 2)
            {
                stack.Push(pq1.Dequeue());
            }
            var e1 = pq1.Dequeue();
            var e2 = pq1.Dequeue();

            var diff = e2-e1;
            if(diff != 0)
            {
                stack.Push(diff);
            }

            while(stack.Count != 0)
            {
                var peek = stack.Peek();
                pq1.Enqueue(stack.Pop(),peek);
            }
        }

        if(pq1.Count == 1) return pq1.Dequeue();
        return 0;
    }
}
