public class Solution {
    public void MoveZeroes(int[] nums) {
        int n= nums.Length;
        int left =0; int right=0;

        for(int r =0; r<n ; r++){
            if(nums[r] != 0){
                var temp = nums[left];
                nums[left] = nums[r];
                nums[r] = temp;
                left++;
            }
        }       
    }

    
}