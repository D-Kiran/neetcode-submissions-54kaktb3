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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode newhead = new(0);
        ListNode dummy = newhead;

        int overhead=0;

        while(l1 != null || l2!= null){
            int v1 = (l1 != null) ? l1.val: 0;
            int v2 = (l2!=null)? l2.val : 0;

            int sum = v1 +v2 + overhead;

            int currentval = sum%10;
            overhead = sum/10;

            newhead.next = new(currentval);
            newhead = newhead.next;

            l1 = (l1 != null) ? l1.next: null;
            l2 = (l2 != null) ? l2.next: null;
        }

        newhead.next = (overhead != 0) ? new(overhead) : null;

        return dummy.next;
    }
}
