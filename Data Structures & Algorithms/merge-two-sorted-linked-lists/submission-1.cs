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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode output = dummy;

        while(list1 != null && list2!= null)
        {
            if(list2.val < list1.val){
                var newNode = new ListNode(list2.val);
                output.next = newNode;
                list2 = list2.next;
            }
            else{
                var newNode = new ListNode(list1.val);
                output.next = newNode;
                list1 = list1.next;
            }
            output = output.next;
        }
        if(list1 != null){
            output.next = list1;
        }
        else{
            output.next = list2;
        }

        return dummy.next;
    }
}