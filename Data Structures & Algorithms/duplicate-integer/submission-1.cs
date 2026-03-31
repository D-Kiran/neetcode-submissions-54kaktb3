public class Solution {
    public bool hasDuplicate(int[] nums) {
       
       var map = new Dictionary<int,int>();
       foreach(var num in nums)
       {
         if(map.ContainsKey(num))
         {
            map[num]+=1;
         }
         else
         {
            map[num]=1;
         }
       }

       foreach(var kvp in map)
       {     
         if(map[kvp.Key] > 1) return true;
       }
       return false;

    }
}