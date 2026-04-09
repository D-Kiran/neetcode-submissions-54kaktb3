public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var numstack = new Stack<int>();

        var result =0;

        for(int i=0; i<tokens.Length; i++){
            var s = tokens[i];

            if(int.TryParse(s, out _)){
                numstack.Push(int.Parse(s));
            }

            else if(s == "+"){
                var a = numstack.Pop();
                var b = numstack.Pop();
                result = b+a;
                numstack.Push(result);
            }

            else if(s == "-"){
                 var a = numstack.Pop();
                var b = numstack.Pop();
                result = b-a;
                numstack.Push(result);
            }
            else if(s == "*"){
                var a = numstack.Pop();
                var b = numstack.Pop();
                result = b*a;
                numstack.Push(result);
            }
            else if(s == "/"){
                var a = numstack.Pop();
                var b = numstack.Pop();
                result = b/a;
                numstack.Push(result);
            }
        }

        return numstack.Pop();
    }
}
