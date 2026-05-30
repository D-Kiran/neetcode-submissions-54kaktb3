public class Solution {
    public List<List<string>> Partition(string s) {
        
        var result = new List<List<string>>();
        var partitions = new List<string>();

        void Dfs(int j, int i, string s){
            if(i >= s.Length){
                if(i == j){
                    result.Add(new List<string>(partitions));
                }
                return;
            }
            

            if(IsPalindrome(s,j,i)){
                partitions.Add(s.Substring(j,i-j+1));
                Dfs(i+1,i+1,s);
                partitions.RemoveAt(partitions.Count - 1);
            }
            Dfs(j,i+1,s);
        }

        Dfs(0,0,s);
        return result;
    }

    private bool IsPalindrome(string s, int left, int right){
        while(left < right){
            if(s[left] != s[right]) return false;
            left++; right--;
        }
        return true;
    }
}
