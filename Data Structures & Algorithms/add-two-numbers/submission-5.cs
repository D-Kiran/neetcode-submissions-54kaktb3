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

            ListNode newHead = new(0);
            ListNode dummy = newHead;

            ListNode current1 = l1; ListNode current2 = l2;
            int overhead = 0;

            while(current1 != null && current2 != null){
                int sum = current1.val+current2.val+overhead;
                var list = GetReverseDigits(sum);
                overhead = list.Count > 1 ? list[1] : 0;
                newHead.next = new ListNode( list[0]);
                newHead = newHead.next;
                current1 = current1.next; current2 = current2.next;
            }

            while(current1 != null)
            {
                int sum = current1.val+overhead;
                var list = GetReverseDigits(sum);
                overhead = list.Count > 1 ? list[1] : 0;
                newHead.next = new ListNode(list[0]);
                newHead = newHead.next;
                current1 = current1.next; 
            }

            while(current2 != null)
            {
                int sum = current2.val+overhead;
                var list = GetReverseDigits(sum);
                overhead = list.Count > 1 ? list[1] : 0;
                newHead.next = new ListNode( list[0]);
                newHead = newHead.next;
                current2 = current2.next; 
            }

           if (overhead != 0) newHead.next = new ListNode(overhead);

           return dummy.next;
    }


    private List<int> GetReverseDigits(int sum){
        var list = new List<int>();
        if (sum == 0) list.Add(0);
        while(sum != 0){
            list.Add(sum%10);
            sum = sum/10;
        }

        return list;
    }

    private void AssignNodes(List<int> list, ListNode head){
        ListNode newNode = new(list[0]);
        head.next = newNode;
        head = newNode;

    }
}