public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxheap = new();


        foreach(var stone in stones){
            maxheap.Enqueue(stone,-stone);
        }

        while(maxheap.Count != 1){
            var first = maxheap.Dequeue();
            var second = maxheap.Dequeue();

            var diff = first-second;
            maxheap.Enqueue(diff, -diff);
        }

        return maxheap.Peek();

    }
}
