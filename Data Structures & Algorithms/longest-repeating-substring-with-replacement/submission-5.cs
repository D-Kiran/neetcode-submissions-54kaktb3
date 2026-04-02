public class Solution {
    public int CharacterReplacement(string s, int k) {

        int n = s.Length;
        int result = 0;

       var dict = new Dictionary<char,int>();
       int left =0;
       for(int right=0; right<n; right++){
          if(!dict.ContainsKey(s[right])){
            dict[s[right]] =1;
          }
          else {
            dict[s[right]]++;
          }
         var mostf = FindMostOccuringCharacterFrequency(dict);
         Console.WriteLine($"mostf {mostf}");
         var windowlength = right-left+1;
         if(windowlength - mostf <= k){
            result = Math.Max(result,windowlength);
         }
         else{
            
            dict[s[left]]--;
            left++;
            
         }

       }
       return result;
    }

    private int FindMostOccuringCharacterFrequency(Dictionary<char,int> dict){
        int max = -1;
        foreach(var kvp in dict){
            max = Math.Max(kvp.Value, max);
        }
        return max;
    }
}
