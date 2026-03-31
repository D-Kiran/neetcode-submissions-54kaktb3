public class Graph {

    private Dictionary<int, List<int>> AdjacencyList;

    public Graph() 
    {
        AdjacencyList = new();
    }

    public void AddEdge(int src, int dst) 
    {
        if(AdjacencyList.ContainsKey(src)){
            AdjacencyList[src].Add(dst);
        }
        else{
            AdjacencyList[src]= new List<int>();
            AdjacencyList[src].Add(dst);
        }
        if(!AdjacencyList.ContainsKey(dst)){
            AdjacencyList[dst]= new List<int>();
        }
    }

    public bool RemoveEdge(int src, int dst) 
    {
        if(!AdjacencyList.ContainsKey(src)){
            return false;
        }
        else{
            if(AdjacencyList[src].Contains(dst))
            {
                AdjacencyList[src].Remove(dst);
                 return true;
            }
           return false;
        }
        return false;
    }

    public bool HasPath(int src, int dst) 
    {
       return Dfs(src,dst,AdjacencyList,new HashSet<int>());
    }

    private bool Dfs(int src, int dst, Dictionary<int,List<int>> adjList, HashSet<int> visit)
    {
       if(visit.Contains(src)) return false;
        if(src == dst) return true;

        visit.Add(src);
        foreach(var neighbour in adjList[src]){
             if(Dfs(neighbour, dst, adjList,visit)) return true;
        } 
        return false;
    }

}
