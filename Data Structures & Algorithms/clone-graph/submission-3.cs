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
    private Dictionary<Node,Node> dict = new();

    public Node CloneGraph(Node node) {

        if(node == null) return null;
        dict[node] = new Node(node.val);
        

        foreach(var nei in node.neighbors){
            if(dict.ContainsKey(nei)){
                dict[node].neighbors.Add(dict[nei]);
            }
            else{
               dict[node].neighbors.Add( CloneGraph(nei));
            }
        }

        return dict[node];
    }
}
