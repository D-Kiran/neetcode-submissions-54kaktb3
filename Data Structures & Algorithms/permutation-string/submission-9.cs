public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var window = s1.Length;
        var s1array = new int[26];
        var s2array = new int[26];
        var match = 0;

        if(s1.Length > s2.Length) return false;

       for(int i=0; i<s1.Length;i++){
          s1array[s1[i]-'a']++;
          s2array[s2[i]-'a']++;
       }

        for(int i=0; i<26;i++){
            if(s1array[i] == s2array[i]) match++;
        }

        int left=0;
        for(int right = s1.Length; right<s2.Length;right++)
        {
            if(match == 26) return true;
            int indexright = s2[right]-'a';
            s2array[indexright] ++;
            if(s2array[indexright] == s1array[indexright])match++;
            else if(s1array[indexright] +1 == s2array[indexright]) match--;

            int indexleft = s2[left]-'a';
            s2array[indexleft]--;
            if(s2array[indexleft] == s1array[indexleft]) match++;
            else if( s1array[indexleft]-1 == s2array[indexleft] ) match--;
            left++;
        }


        if(match == 26) return true;

        return false;
    }
}
