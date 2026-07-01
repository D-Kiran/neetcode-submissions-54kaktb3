public class Solution {
    Dictionary<int, List<int>> dict = new();
    HashSet<int> visited = new();

    public int CountComponents(int n, int[][] edges) {
        for(int i=0; i<n; i++){
            dict[i] = new List<int>();
        }

        foreach(var pair in edges){
            dict[pair[0]].Add(pair[1]);
            dict[pair[1]].Add(pair[0]);
        }

        var connectedComponents = 0;
        for(int i=0 ;i<n ;i++){
            if(!visited.Contains(i)){
                Dfs(i,-1);
                connectedComponents++;
            }
        }
        return connectedComponents;
    }

    private void Dfs(int node, int parent){
        visited.Add(node);

        foreach(var nei in dict[node]){
            if(nei == parent) continue;
            if(visited.Contains(nei)) continue;
            Dfs(nei,node);
        }
    }
}
