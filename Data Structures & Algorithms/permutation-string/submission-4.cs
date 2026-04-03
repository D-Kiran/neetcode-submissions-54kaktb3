public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var dict1 = new Dictionary<char,int>();
        var window = s1.Length;
        var s1array = new int[26];

        foreach(var ch in s1){
           s1array[ch-'a']++;
        }

        for(int i =0; i<s2.Length;i++){
            if(!s1.Contains(s2[i])) continue;
            if(i+window-1 >= s2.Length) break;
            var sub = s2.Substring(i,window);
            var isvalid = true;
           // Console.WriteLine(sub);
            var s2array = new int[26];
            for(int j=0;j<sub.Length;j++){
                s2array[sub[j]-'a']++;               
            }
            for(int k=0; k<26;k++){
               // Console.WriteLine(s1array[k]);
               // Console.WriteLine(s2array[k]);
                if(s1array[k] != s2array[k]){
                    isvalid = false;
                    break;
                } 
                
            }
            
            if(isvalid) return true;
        }

        return false;
    }
}
