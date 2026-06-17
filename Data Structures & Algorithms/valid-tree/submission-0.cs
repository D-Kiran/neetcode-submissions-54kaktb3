public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length > n -1) return false;

        List<List<int>> adj = new();
        for(int i=0; i<n;i++){
            adj.Add(new List<int>());
        }

        foreach(var edge in edges){
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        HashSet<int> visit = new();
        Queue<(int,int)> queue = new();

        queue.Enqueue((0,-1));
        visit.Add(0);

        while(queue.Count > 0){
            var (node,parent)= queue.Dequeue();
            foreach(var nei in adj[node]){
                if(nei == parent) continue;
                if(visit.Contains(nei)) return false;

                visit.Add(nei);
                queue.Enqueue((nei,node));
            }
        }

        return visit.Count == n;
    }
}
