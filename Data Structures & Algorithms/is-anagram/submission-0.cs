public class Solution {
    public bool IsAnagram(string s, string t) {
       var array1 = new int[26];
       var array2 = new int[26];

       for(int i=0; i<s.Length; i++)
       {
          array1[(int)s[i]-97]++;
       }

        for(int i=0; i<t.Length; i++)
       {
          array2[(int)t[i]-97]++;
       }

       for(int i=0; i<26; i++){
        if(array1[i] != array2[i])return false;
       }
       return true;
    }
}
