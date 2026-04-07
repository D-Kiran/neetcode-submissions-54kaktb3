public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();

        for(int i=0; i<s.Length; i++){
            var ch = s[i];
            char popped='a';

            if(ch == '[' || ch == '(' || ch == '{'){
                stack.Push(ch);
            }
            if(stack.Count == 0) return false;
            
            else if (ch == ']' ){
                 popped = stack.Pop();
                if(popped != '[') return false;               
            }
             else if (ch == '}'){
                 popped = stack.Pop();
                if(popped != '{') return false; 

            }
             else if (ch == ')'){
                 popped = stack.Pop();
                if(popped != '(') return false; 
            }
        }

        return stack.Count ==0;
    }
}
