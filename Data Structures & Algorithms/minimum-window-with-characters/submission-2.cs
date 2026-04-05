public class Solution {
    public string MinWindow(string s, string t) {
        int left =0;

        var dictT = new Dictionary<char,int>();

        foreach(char ch in t){
            if(dictT.ContainsKey(ch)){
                dictT[ch]++;
            }
            else{
                dictT[ch]=1;
            }
        }

        var minLength = Int32.MaxValue;
        var window = new Dictionary<char,int>();
        var match=0; var requiredmatch = dictT.Count;
        var result = new int[2];

        for(int right =0; right<s.Length; right++){
            //add to dictionary
            var ch = s[right];
            if(window.ContainsKey(ch)){
                window[ch]++;
            }
            else{
                window[ch] =1;
            }

            //update the match
            if(t.Contains(ch) && dictT[ch] == window[ch]){
                match++;
            }

            while (match == requiredmatch)
            {
                //update the length
                if(right-left+1 < minLength){
                     minLength = right-left+1;
                     //keep track of indices to return the string
                   result[0]=left; result[1]=right;
                }
               
                
                //increment left
                   //decrement count of leftt element in the window dictionary
                   var leftelement = s[left];
                   window[leftelement]--;
                   //reduce the match only if t contains it and the count of the leftelement is less than the t dict
                   if(t.Contains(leftelement) && window[leftelement] < dictT[leftelement]) match--;
                   left++;
            }

            
        }

        return minLength == Int32.MaxValue?"":s.Substring(result[0],minLength);
    }
}
