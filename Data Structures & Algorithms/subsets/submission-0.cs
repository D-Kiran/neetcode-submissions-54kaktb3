public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var output = new List<List<int>>();

        output.Add(new List<int>());

        foreach(var num in nums){
            int size = output.Count;
            for(int i=0;i<size;i++){
                var subset = new List<int>(output[i]);
                subset.Add(num);
                output.Add(subset);
            }
        }

        return output;
    }
}
