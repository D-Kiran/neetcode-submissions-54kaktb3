public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] indegree = new int[numCourses];
        var adj = new List<List<int>>();
        for(int i=0; i<numCourses; i++){
            adj.Add(new List<int>());
        }

        foreach(var pre in prerequisites){
            indegree[pre[1]]++;
            adj[pre[0]].Add(pre[1]);
        }

        Queue<int> queue = new();
        for(int i=0; i<numCourses; i++){
            if(indegree[i] == 0){queue.Enqueue(i);}
        }

        int finish = 0;
        
        while(queue.Count > 0){
            int node = queue.Dequeue();
            finish++;
            foreach(var nei in adj[node]){
                indegree[nei]--;
                if(indegree[nei] == 0){
                    queue.Enqueue(nei);
                }
            }
        }

        return finish == numCourses;
    }
}
