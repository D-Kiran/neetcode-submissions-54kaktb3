public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max =0;
        var set= new HashSet<char>();

        int left=0;
        for(int right =0; right<s.Length; right++){
            var ch = s[right];
            if(!set.Contains(ch)){
                set.Add(ch);
            }
            else{
                while(set.Contains(ch)){
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(ch);
            }

            max = Math.Max(max, right-left+1);
        }

        return max;

    }
}
