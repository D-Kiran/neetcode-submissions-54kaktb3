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
        
        //Find the total length of linkedlist
        int length =0;
        ListNode temphead = head;
        while(temphead != null){
            temphead = temphead.next;
            length++;
        }

        int mid = length%2==0? length/2 : (length/2)+1;

        //nodes beyond mid should be stored in stack

        int current = 0;
        var stack = new Stack<ListNode>();
        ListNode temphead2 = head;
        while(temphead2 != null){           
            current ++;
            if(current > mid){
                stack.Push(temphead2);
            }
            temphead2 = temphead2.next;
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
