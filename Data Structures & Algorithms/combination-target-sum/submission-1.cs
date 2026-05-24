public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var result = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index, int total){
            if(total == target){
                result.Add(new List<int>(current));
                return;
            }
            if(index == nums.Length || total > target) return;


            current.Add(nums[index]);
            Dfs(index, total+nums[index]);

            current.RemoveAt(current.Count -1);
            Dfs(index+1, total);
        }
        Dfs(0,0);
        return result;
    }
}
