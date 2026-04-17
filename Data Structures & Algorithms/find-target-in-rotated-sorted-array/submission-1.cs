public class Solution {
    public int Search(int[] nums, int target) {
        //one pass

        int left=0; int right = nums.Length-1;

        while(left <= right){
            int mid = (left+right)/2;

            if(nums[mid] == target) return mid;

            //left half is sorted
            if(nums[left] <= nums[mid]){
                
                  //target is less than the least element in sorted array, look right
                  if(target < nums[left]) left = mid+1;

                  //target is greater than the max element in sorted array, look right
                  else if(target > nums[mid]) left = mid+1;

                  //target > min and target < max, look here
                  else right = mid-1;
            }

            //right half is sorted 

            else{
                //target is greater than max element in sorted array, look left
                if(target > nums[right]) right = mid-1;
                
                //target less than the min element in sorted array, look left
                else if(target < nums[mid]) right = mid-1;

                //target > min and target < max, look here
                else left = mid+1;
            }
        }
       
       return -1;
    }

    
}
