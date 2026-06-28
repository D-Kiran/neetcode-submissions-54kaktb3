public class Solution {
     Dictionary<int, List<int>> dict = new();

    HashSet<int> visited = new();
    public bool CanFinish(int numCourses, int[][] prerequisites) {
       
       for(int i=0 ; i<numCourses; i++){
            dict[i] = new List<int>();
        }

        foreach(var pre in prerequisites){            
            dict[pre[0]].Add(pre[1]);
        }

        for(int i=0 ; i<numCourses; i++){
            if(!Dfs(i)) return false;
        }
        return true;
        
    }

    private bool Dfs(int course){
        if(visited.Contains(course)) return false;
        if(dict[course].Count == 0) return true;

        visited.Add(course);
        foreach(var pre in dict[course]){
            if(!Dfs(pre)) return false;

        }

        visited.Remove(course);
        dict[course].Clear();
        return true;
    }
}
