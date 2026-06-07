/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {

    private Dictionary<Node,Node> map = new();


    public Node CloneGraph(Node node) {

        if(node == null) return null;
        var first = new Node(node.val);
        map[node]  = first;

        var queue = new Queue<Node>();

        queue.Enqueue(node);

        while(queue.Count > 0){
            var current = queue.Dequeue();
            foreach(var nei in current.neighbors){
                if(!map.ContainsKey(nei)){

                    map[nei] = new Node(nei.val);
                    queue.Enqueue(nei);
                }
                map[current].neighbors.Add(map[nei]);               
            }
        }
        
        return first;
    }
    
}
