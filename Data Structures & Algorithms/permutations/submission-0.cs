public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        return Helper(0,nums);
    }

    private List<List<int>> Helper(int index, int[] nums){
        if(index == nums.Length){
            return new List<List<int>>{new List<int>()};            
        }

        var finalresult = new List<List<int>>();
        var permfromnextindex = Helper(index+1, nums);

        foreach(var li in permfromnextindex){            
            for(int j=0; j<li.Count+1; j++){
                var pcopy = new List<int>(li);
                pcopy.Insert(j,nums[index]);
                finalresult.Add(pcopy);
            }
        }

        return finalresult;
    }
}
