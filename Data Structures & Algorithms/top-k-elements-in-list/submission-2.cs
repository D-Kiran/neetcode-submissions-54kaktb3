public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dict = new Dictionary<int,int>();
       var frequencyArray = new List<int>[nums.Length+1];

      for(int i=0; i<frequencyArray.Length; i++)
      {
        frequencyArray[i] = new List<int>();
      }

       for(int i=0; i<nums.Length;i++)
       {
          
          if(dict.ContainsKey(nums[i])){
            dict[nums[i]]++;
          }
          else{
            dict[nums[i]]=1;
          }
       }

       foreach(var kvp in dict)
       {
          frequencyArray[kvp.Value].Add(kvp.Key);
       }
         
        int index=0;
        var output = new int[k];
        for(int i=frequencyArray.Length-1; i>0 && index<k; i--)
        {
            var elementsintopfrequency = frequencyArray[i];
            foreach(var element in elementsintopfrequency)
            {
                output[index] = element;
                index++;
            }   
        }
        return output;

    }
}
