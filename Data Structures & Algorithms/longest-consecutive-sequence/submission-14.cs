public class Solution {
    public int LongestConsecutive(int[] nums) 
    {

       if(nums.Length == 0) return 0;
       var set = new HashSet<int>();
       for(int i=0; i<nums.Length; i++)
       {
          set.Add(nums[i]);
       }

       var longest= 1;
       foreach(var numb in set)
       {
          //check if it's start of sequence by checking it's left neighbours, meaning if n-1 doesnt exist then 
          //its a start of sequence
          var length=1;
          if(!set.Contains(numb-1))
          {   
            var startofsequence = numb;         
            while(set.Contains(startofsequence+1))
            {
               length++;
               startofsequence++;
            }
          }
          longest = Math.Max(length,longest);
       }

       return longest;
    }
}