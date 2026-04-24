/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        var dict = new Dictionary<Node,Node>();


        Node current = head;
        while(current != null){
            Node copy = new Node(current.val);
            dict[current] = copy;
            current = current.next;
        }

        current = head;
        while(current != null){
            Node copy = dict[current];
            copy.next = current.next != null ? dict[current.next]:null;
            copy.random = current.random != null ? dict[current.random]:null;
            current = current.next;
        }

        return head != null ? dict[head]:null;
    }
}
