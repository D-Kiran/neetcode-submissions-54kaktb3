public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int n = temperatures.Length;
       var result = new int[n];
       var stack = new Stack<int[]>(); //index, temperature
       
       for(int i=0; i<n; i++)
       {
           int current = temperatures[i];

           while(stack.Count >0 && current > stack.Peek()[1]){
                var pair = stack.Pop();
                result[pair[0]] = i - pair[0];
           }

           stack.Push(new int[]{i,current});
       }

       return result;

    }
}
