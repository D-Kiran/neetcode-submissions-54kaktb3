public class Solution {
    public int RemoveDuplicates(int[] nums) {
      var dict = new Dictionary<int,int>();

      for(int i=0; i<nums.Length;i++){
         if(dict.ContainsKey(nums[i])){
            dict[nums[i]]++;
         }
         else{
            dict[nums[i]] = 1;
         }
      }

      int k=0;
      foreach(var kvp in dict){
         nums[k] = kvp.Key;
         k++;
      }
      return k;
    }
}