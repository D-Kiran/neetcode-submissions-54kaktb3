public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        var s1array = new int[26];
        var s2array = new int[26];
        int matches=0;

        if(s1.Length > s2.Length) return false;

        for(int i=0; i<s1.Length; i++){
            s1array[s1[i] - 'a']++;
            s2array[s2[i]-'a']++;
        }

        for(int i=0; i<26;i++){
            if(s1array[i] == s2array[i]) matches++;
        }

        int left=0;
        for(int right=s1.Length; right<s2.Length; right++){
            if(matches == 26) return true;

            int idx_r = s2[right]-'a';
            s2array[idx_r]++;
            if(s1array[idx_r] == s2array[idx_r]) matches++;
            else if((s1array[idx_r] +1) == s2array[idx_r]) matches--;

            int idx_l = s2[left]-'a';
            s2array[idx_l]--;
            left++;
            if(s1array[idx_l] == s2array[idx_l]) matches++;
            else if(s1array[idx_l] -1 == s2array[idx_l]) matches--;
        }
        return matches == 26;
    }
}
