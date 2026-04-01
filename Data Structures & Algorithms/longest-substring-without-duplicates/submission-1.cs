public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        // optimised
        int n= s.Length;
        int max = 0;

        int left=0;
        var set = new HashSet<char>();
        for(int right =0; right<n; right++)
        {   
            if(!set.Contains(s[right])){
                set.Add(s[right]);
            }
            else{
                while(set.Contains(s[right])){
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
            }
            max = Math.Max(max, right-left+1);
        }

        return max;
        
    }
}
