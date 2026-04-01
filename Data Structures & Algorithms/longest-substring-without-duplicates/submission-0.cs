public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        // brute force
        int n= s.Length;
        int max = 0;
        for(int i=0; i<n;i++){
            var set = new HashSet<char>();
            for(int j=i; j<n; j++){
                if(set.Contains(s[j])) break;
                set.Add(s[j]);
            }
            max = Math.Max(max, set.Count);
        }
        return max;
    }
}
