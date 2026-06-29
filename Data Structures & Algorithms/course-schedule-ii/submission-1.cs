public class Solution {
    Dictionary<int,List<int>> dict = new();
    HashSet<int> visited = new();
    HashSet<int> cycle = new();
    List<int> output = new();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        for(int i=0; i<numCourses; i++){
            dict[i] = new List<int>();
        } 

        foreach(var pair in prerequisites){
            dict[pair[0]].Add(pair[1]);
        }

        for(int i=0 ; i<numCourses; i++){
            if(!Dfs(i)) return new int[0];
            
        }
        return output.ToArray();
    }

    private bool Dfs(int course){
        if(cycle.Contains(course)) return false;
        if(visited.Contains(course)) return true;

        cycle.Add(course);
        foreach(var nei in dict[course]){
            if(!Dfs(nei)) return false;
        }
        cycle.Remove(course);
        visited.Add(course);
        output.Add(course);
        return true;
    }
}
