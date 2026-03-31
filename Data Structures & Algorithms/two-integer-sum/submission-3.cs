public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
       //optimised

       var dict = new Dictionary<int,int>();
       for(int i=0; i<nums.Length;i++)
       {
          int element = nums[i];
          int difference = target- element;

          if(dict.ContainsKey(difference)){
            return new int[2]{dict[difference],i};
          }
          else{
            dict[element] = i;
          }
       }
       return new int[2]{0,0};
    }
}
