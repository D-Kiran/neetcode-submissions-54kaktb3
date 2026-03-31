public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        int left = 0; int right=0;
        int n = nums.Length;
        var result = new List<List<int>>();
        Array.Sort(nums);

        for(int i=0; i<n ;i++){

            int element = nums[i];

            left = i+1; right = n-1;

            if(i>0 && nums[i] == nums[i-1]) continue;

            while(left < right){
                int sum = element + nums[right]+nums[left];

                if(sum == 0){
                    var triplet = new List<int>(){element, nums[left], nums[right]};
                    result.Add(triplet);
                    left++; right--;

                    while(left < right && nums[left] == nums[left-1]) left++;
                }
                else if(sum > 0){
                    right --;
                }
                else{left++;}
            }
        }
        
        return result;
    }
}
