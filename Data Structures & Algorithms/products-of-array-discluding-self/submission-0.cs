public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var output = new int[nums.Length];
          for(int i=0; i<nums.Length ;i++)
          {
            var product =1;
            for(int j=0; j<nums.Length; j++)
            {
                if(j == i) continue;
                product *= nums[j];
            }
            output[i] = product;
          }

          return output;
    }
}
