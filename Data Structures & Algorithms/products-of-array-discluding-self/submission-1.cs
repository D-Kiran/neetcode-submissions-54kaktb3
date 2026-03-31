public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
      var n = nums.Length;
       var prefixProduct = new int[n];
       prefixProduct[0]=nums[0];
       var postfixProduct = new int[n];
       postfixProduct[n-1]= nums[n-1];

       var output = new int[n];

       for(int i=1; i<n; i++){
        prefixProduct[i] = prefixProduct[i-1]*nums[i];
       }

       for(int j=n-2;j>=0;j--){
        postfixProduct[j] = postfixProduct[j+1]* nums[j];
       }

       for(int k=0 ; k<n; k++){
        if(k == 0) 
        {
          output[k]= postfixProduct[k+1];
        }
        else if(k == n-1){
          output[k] = prefixProduct[k-1];
        }
        else{
          output[k] = prefixProduct[k-1] * postfixProduct[k+1];
        }
       }

       return output;
    }
}
