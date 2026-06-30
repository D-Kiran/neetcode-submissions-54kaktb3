public class Solution {

    Dictionary<int, List<int>> dict = new();
    HashSet<int> visited = new();

    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length > n-1) return false;

        for(int i=0 ; i<n ; i++){
            dict[i] = new List<int>();
        }

        foreach(var pair in edges){
            dict[pair[0]].Add(pair[1]);
            dict[pair[1]].Add(pair[0]);
        }

        if(!Dfs(0,-1)) return false;

        return visited.Count == n;
    }

    private bool Dfs(int node, int parent){
        visited.Add(node);
        foreach(var nei in dict[node]){
            if(nei == parent) continue;
            if(visited.Contains(nei)) return false;
            if(!Dfs(nei,node)) return false;
            
        }
        return true;
    }
}
