public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int left =0; int right=0;

       while(right < nums.Length){
         nums[left] = nums[right];
         while(right < nums.Length && nums[left] == nums[right])
         {
            right++;
         }
         left++;
       }

       return left;
    }
}