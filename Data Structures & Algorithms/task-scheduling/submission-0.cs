public class Solution {
    public int LeastInterval(char[] tasks, int n) {

        PriorityQueue<int,int> maxheap = new();

        int[] countarray = new int[26];
        foreach(var ch in tasks){
            countarray[(int)ch-'A']++;
        } 

        foreach(var occurance in countarray){
            if(occurance > 0){
                maxheap.Enqueue(occurance, -occurance);
            }
        }  

        Queue<int[]> queue = new();
        int time =0;

        while(maxheap.Count >0 || queue.Count >0){
            time++;
            var count = maxheap.Count >0 ? maxheap.Dequeue() : 0;
            count -=1;
            if(count > 0) queue.Enqueue(new int[2]{count, time+n});

            if(queue.Count >0 && queue.Peek()[1] == time){
                var updatedcount = queue.Dequeue()[0];
                maxheap.Enqueue(updatedcount,-updatedcount);
            }
        } 

        return time;                                                                                                                                                                                  
    }
}



