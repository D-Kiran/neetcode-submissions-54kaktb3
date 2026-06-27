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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;

        var second = head.next; 
         var newhead = ReverseList(second);
            second.next = head;
        
       
        head.next = null;
        return newhead;
    }
}
