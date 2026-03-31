public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n= nums.Length;
        var output =new int[2*n];

        for(int i=0; i<n;i++){
            output[i]=nums[i];
        }
        for(int i=0;i<n;i++){
            int j=i+n;
            output[j]=nums[i];
        }

        return output;
    }
}