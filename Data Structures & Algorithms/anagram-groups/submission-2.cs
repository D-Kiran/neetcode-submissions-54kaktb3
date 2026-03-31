public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var dict = new Dictionary<string, List<string>>();
        
        for(int i=0; i<strs.Length; i++)
        {
            var frequency = CreateFrequencyArray(strs[i]);
            var key = string.Join(",", frequency);
            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }
            dict[key].Add(strs[i]);           
        }

        var result = new List<List<string>>();
        foreach(var kvp in dict)
        {
            result.Add(kvp.Value);
        }

        return result;
        
    }

    private int[] CreateFrequencyArray(string element)
    {
        var frequency = new int[26];
        foreach(var ch in element){
            frequency[(int)ch-97] ++;
        }
        return frequency;
    }

   
}
