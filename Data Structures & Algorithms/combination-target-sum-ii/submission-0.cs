public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index, int total){
            if(total == target){
                result.Add(new List<int>(current));
                return;
            }
            if(index == candidates.Length || total > target) return;

            current.Add(candidates[index]);
            Dfs(index+1,total+candidates[index]);

            current.RemoveAt(current.Count-1);

            while(index+1 < candidates.Length && candidates[index] == candidates[index+1]) index++;
            Dfs(index+1,total);
        }

        Dfs(0,0);
        return result;


    }
}
