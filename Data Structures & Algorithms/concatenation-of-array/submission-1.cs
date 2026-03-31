public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n= nums.Length;
        var output =new int[2*n];

        for(int i=0; i<n;i++){
            output[i]= output[i+n] = nums[i];
        }       
        return output;
    }
}