public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var numstack = new Stack<int>();

        var result =0;
        var a =0;
        var b=0;

        for(int i=0; i<tokens.Length; i++){
            var s = tokens[i];

            if(int.TryParse(s, out _)){
                numstack.Push(int.Parse(s));
            }

            else if(s == "+"){
                 a = numstack.Pop();
                 b = numstack.Pop();
                result = b+a;
                numstack.Push(result);
            }

            else if(s == "-"){
                  a = numstack.Pop();
                 b = numstack.Pop();
                result = b-a;
                numstack.Push(result);
            }
            else if(s == "*"){
                 a = numstack.Pop();
                 b = numstack.Pop();
                result = b*a;
                numstack.Push(result);
            }
            else if(s == "/"){
                 a = numstack.Pop();
                 b = numstack.Pop();
                result = b/a;
                numstack.Push(result);
            }
        }

        return numstack.Pop();
    }
}
