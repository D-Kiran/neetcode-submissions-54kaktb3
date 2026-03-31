public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();
        for(int i=0; i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i])){
                map[nums[i]] = i;
            }
            else{
                map.Add(nums[i],i);
            }
            
        }

        for(int i=0; i<nums.Length;i++){
            var curr = nums[i];
            var diff = target-curr;
            if(map.ContainsKey(diff) && map[diff] != i)
            {
                return new int[]{i,map[diff]};
            }
        }
        return new int[2];
    }
}
