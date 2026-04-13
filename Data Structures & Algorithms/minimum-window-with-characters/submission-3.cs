public class Solution {
    public string MinWindow(string s, string t) {
        
        var dictT = new Dictionary<char,int>();

        for(int i=0 ;i<t.Length; i++){
            if(dictT.ContainsKey(t[i])){
                dictT[t[i]]++;
            }
            else{
                dictT[t[i]]= 1;
            }
        }

        int left=0;
        var dictS = new Dictionary<char,int>();
        int requiredmatches = dictT.Count;
        int actualmatches = 0;
        var result = new int[2];
        int length = Int32.MaxValue;

        for(int right=0; right<s.Length; right++)
        {
            var ch = s[right];
            if(dictS.ContainsKey(ch)){
                dictS[ch]++;
            }
            else{
                dictS[ch] = 1;
            }

            if(t.Contains(ch) && dictT[ch] == dictS[ch]){
                actualmatches ++;
            }

            while(actualmatches == requiredmatches)
            {
                if((right-left+1)< length)
                {
                    length = right-left+1;
                    result[0] = left; result[1]= right;
                }           
                dictS[s[left]]--;
                if(t.Contains(s[left]) && dictS[s[left]] < dictT[s[left]]){
                    actualmatches--;
                }

                left++;
            }
        }

        return length == Int32.MaxValue?"":s.Substring(result[0], length);
         
    }
}
