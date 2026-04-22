/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        
        //nodes beyond mid should be stored in stack

        var stack = new Stack<ListNode>();
        ListNode slow = head; ListNode fast = head.next;

        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        while(slow != null){
            slow = slow.next;
            if(slow != null) stack.Push(slow);
        }
        

        //re-order
        while(stack.Count > 0){
            ListNode temp = head.next;
            head.next = stack.Pop();
            head.next.next = temp;
            head = temp;//head.next.next;
        }
        head.next = null;
    }
}
