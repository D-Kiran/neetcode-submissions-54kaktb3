public class Solution {
    public int Search(int[] nums, int target) {
        
        //Find the index of minimum element it's the pivot

        int left = 0; int right = nums.Length-1;

        while(left < right){
            int mid = (left + right)/2;
            if(nums[mid] > nums[right]) left = mid+1;
            else if(nums[mid] < nums[right]) right = mid;
        }

        //search the first half if not found then search the second half then return result
        int result = BinarySearch(0, left-1,nums, target);
        if(result == -1){
            result = BinarySearch(left, nums.Length-1,nums, target);
        }

        return result;
    }

    private int BinarySearch(int left, int right, int[] nums, int target)
    {
        while(left <= right){
            int mid = (left+right)/2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] > target) right = mid-1;
            else left = mid+1;
        }
        return -1;
    }
}
