public class Solution {
    public int FindMin(int[] nums) {
        int left = 0; int right = nums.Length-1;

        while(left <= right){
            int mid = (left+right)/2;
            if(left == right) return nums[left];
            if(nums[mid] > nums[right]){
                left = mid+1;
            }
            else if(nums[mid] < nums[right]){
                right = mid;
            }
        }

        return nums[left];
    }
}
