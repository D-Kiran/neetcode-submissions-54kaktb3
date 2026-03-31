public class Solution {
    private List<List<int>> output;

    public List<List<int>> Subsets(int[] nums) {
        output = new List<List<int>>();
        var subset = new List<int>();
        Backtracking(nums,0,subset);
        return output;
    }

    private void Backtracking(int[] nums,int i,List<int> subset)
    {
        if( i == nums.Length){
            output.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[i]);
        Backtracking(nums,i+1,subset);
        subset.RemoveAt(subset.Count-1);
        Backtracking(nums,i+1,subset);
    }
}
