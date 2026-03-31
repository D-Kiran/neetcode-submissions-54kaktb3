public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int L =1;
        int R= 1;

        while(R < nums.Length){
            if(nums[R] != nums[R-1]){
                nums[L] = nums[R];
                L++;
            }
            R++;
        }
        return L;
    }
}