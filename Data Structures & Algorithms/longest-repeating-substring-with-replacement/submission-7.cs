public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> countdict = new Dictionary<char, int>();
        int result = 0;

        int mosftfrequentelementcount = -1;

        int left =0;

        for(int right =0; right<s.Length; right++){
            var ch = s[right];
            if(countdict.ContainsKey(ch)){
                countdict[ch]++;
            }
            else{
                countdict[ch]=1;
            }
            mosftfrequentelementcount = Math.Max(mosftfrequentelementcount, countdict[ch]);

            var windowlength = right-left+1;

            if(windowlength - mosftfrequentelementcount <=k){
                result = Math.Max(result, windowlength);
            }
            else{
                countdict[s[left]]--;
                left++;
            }
        }

        return result;

        
    }
}
