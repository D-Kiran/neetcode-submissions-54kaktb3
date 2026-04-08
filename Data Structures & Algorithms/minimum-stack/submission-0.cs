public class MinStack {

    Stack<int> regularstack;
    Stack<int> minstack;
     

    public MinStack() {
       regularstack = new();
        minstack = new();
    }
    
    public void Push(int val) {
        regularstack.Push(val);
        if(minstack.Count == 0){
            minstack.Push(val);
        }
        else if(minstack.Peek()>=val){
            minstack.Push(val);
        }
    }
    
    public void Pop() {
        var popped = regularstack.Pop();
        if(popped == minstack.Peek()){
            minstack.Pop();
        }
    }
    
    public int Top() {
       return regularstack.Peek();
    }
    
    public int GetMin() {
        return minstack.Peek();
    }
}
