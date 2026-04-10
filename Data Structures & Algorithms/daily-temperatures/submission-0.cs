public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int n = temperatures.Length;
       var result = new int[n];
       
       for(int i=0; i<n; i++)
       {
           var current = temperatures[i];
           var nextwarmerday = -1;
           for(int j=i+1; j<n ; j++)
           {
              var next = temperatures[j];
              if(next > current)
              {
                nextwarmerday = j-i;
                break;                
              }
           } 
           result[i] = nextwarmerday == -1 ? 0: nextwarmerday;
       }

       return result;

    }
}
