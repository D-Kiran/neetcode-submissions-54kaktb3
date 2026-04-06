public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int n = nums.Length;
        var result = new int[n+1-k];

        var max = Int32.MinValue;
        for(int i=0; i<k;i++){
           max = Math.Max(max, nums[i]);
        }
        result[0]=max;

        int left=0;
        for(int right=k; right<n; right++){

            var currentmax = result[left];
            if(nums[left] == currentmax && nums[right] < currentmax){
                result[left+1] = RecalculateMax(left+1, right, nums);
            }
            else if(nums[left] <= currentmax && nums[right] >= currentmax){
                result[left+1]= nums[right];
            }
            else if(nums[left] < currentmax && nums[right] < currentmax){
                result[left+1] = currentmax;
            }
            left++;
        }


        return result;
    }

    private int RecalculateMax(int left, int right, int[] nums){
         var max = Int32.MinValue;

        for(int i=left; i<=right; i++){
            max = Math.Max(max, nums[i]);
        }
        return max;
    }
}
