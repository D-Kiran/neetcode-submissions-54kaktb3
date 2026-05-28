public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        Backtrack(0,0,n,result , "" );
        return result;

    }

    private void Backtrack(int openN, int closedN,int n, List<string> result, string parantheses){
          if(openN==closedN && openN==n){
            result.Add(parantheses);
            return;
          }

          if(openN < n){
            Backtrack(openN+1, closedN,n,result,parantheses + '(');
          }

          if(closedN < openN){
            Backtrack(openN, closedN+1, n, result, parantheses + ')');
          }
    }
}
