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
        
        ListNode slow = head; ListNode fast = head.next;

        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }

        ListNode secondhalf = slow.next;
        slow.next = null; ListNode previous = null;

        while(secondhalf != null){
            ListNode temp = secondhalf.next;
            secondhalf.next = previous;
            previous = secondhalf;
            secondhalf = temp;
        }

        ListNode firsthalf = head;
        secondhalf = previous;

        while(secondhalf != null){
            ListNode temp1 = firsthalf.next;
            ListNode temp2 = secondhalf.next;
            firsthalf.next = secondhalf;
            secondhalf.next = temp1;
            firsthalf = temp1;
            secondhalf = temp2;
        }
        
    }
}
