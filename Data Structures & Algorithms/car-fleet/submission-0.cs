public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        var pairs = new int[position.Length][];

        for(int i=0; i< position.Length; i++){
            pairs[i] = new int[]{position[i],speed[i]};
        }   

        Array.Sort(pairs, (a,b) => b[0].CompareTo(a[0])); //compare positions

        var stack = new Stack<double>();

        foreach(var p in pairs){
            var timetodestination = (double)(target-p[0])/p[1];
            stack.Push(timetodestination);
            if(stack.Count > 1 && stack.Peek() <= stack.ElementAt(1)){
                stack.Pop();
            }
        }

        return stack.Count;
    }
}
