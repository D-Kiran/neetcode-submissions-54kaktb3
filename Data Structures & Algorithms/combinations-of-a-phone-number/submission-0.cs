public class Solution {
    public List<string> LetterCombinations(string digits) {
         List<string> result = new();
         Dictionary<char,string> digitToChar = new(){
             {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "qprs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

        if(digits.Length == 0) return result;
        

        void Backtrack(int idx, string current,string digits){
            if(current.Length == digits.Length){
                result.Add(current);
                return;
            }

            foreach(var ch in digitToChar[digits[idx]]){
                Backtrack(idx+1, current+ch, digits);
            }
        }

        Backtrack(0,"",digits);
        return result;
    }
}
