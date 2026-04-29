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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0,head);
        var groupPrev = dummy;

        while(true)
        {
            var kthNode = GetKthNode(groupPrev,k);
            if(kthNode == null) break;
            ListNode groupNext = kthNode.next;
            ListNode previous = kthNode.next;
            ListNode current = groupPrev.next;
            while(current != groupNext){
                var temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            var tempNode = groupPrev.next;
            groupPrev.next = kthNode;
            groupPrev = tempNode;
        }
        return dummy.next;
    }

    private ListNode GetKthNode(ListNode current,int k){
        while(current != null && k >0){
            current = current.next; k--;
        }
        return current;
    }
}
