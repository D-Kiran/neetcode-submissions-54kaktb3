public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        //brute force
        var result = new List<List<string>>();
        for(int i=0; i<strs.Length; i++)
        {
            if(i!=0 && AlreadyExists(result,strs[i]))
            {
                continue;
            }
            var anagrams = new List<string>();
            anagrams.Add(strs[i]);
            var frequency = CreateFrequenecyArray(strs[i]);

            for(int j=i+1; j<strs.Length;j++)
            {
                if(strs[j].Length == strs[i].Length &&
                    FrequenciesMatch(frequency,strs[j]))
                {
                    anagrams.Add(strs[j]);
                }
                
            }

            result.Add(anagrams);
            
        }
        return result;
    }

    private bool AlreadyExists(List<List<string>> result, string element)
    {
        foreach(var list in result)
        {
            if(list.Contains(element)) return true;
        }
        return false;
    }

    private int[] CreateFrequenecyArray(string element)
    {
        var frequency = new int[26];

        foreach(var ch in element)
        {
            frequency[(int)ch-97] ++;
        }
        return frequency;
    }

    private bool FrequenciesMatch(int[] frequency, string element)
    {
        var frequency2 = CreateFrequenecyArray(element);
        for(int i=0; i<26; i++)
        {
            if(frequency[i] != frequency2[i]) return false;
        }
        return true;
    }
}
