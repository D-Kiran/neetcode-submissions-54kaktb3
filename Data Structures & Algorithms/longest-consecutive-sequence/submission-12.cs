public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        Array.Sort(nums);
        if(nums.Length == 0) return 0;
        int maxConsecutive = 1;
        int currentConsecutive = 1;
        for(int i=1; i<nums.Length; i++){
            if(nums[i] == nums[i-1]) continue;
            if(nums[i] - nums[i-1] == 1) {
                currentConsecutive++;
            } else {
                currentConsecutive = 1;
            }
            if(currentConsecutive > maxConsecutive) maxConsecutive = currentConsecutive;
        }    
        return maxConsecutive;
    }
}