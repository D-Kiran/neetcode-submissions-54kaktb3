public class Solution {

    private int target ;
    private List<List<int>> output;
    private int[] nums;

    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        this.target =  target;
        output = new();
        this.nums = nums;
        Backtrack(0,0,new List<int>());
        return output;

    }

    private void Backtrack(int i, int sum, List<int> current){
        if(sum == target) {
            output.Add(new List<int>(current));
            return;
        }

        if(sum > target || i == nums.Length) return;

        current.Add(nums[i]);
        Backtrack(i,sum+nums[i],current);
        current.RemoveAt(current.Count-1);
        Backtrack(i+1, sum, current);
    }
}
