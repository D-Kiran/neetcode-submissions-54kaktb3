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

        
        ListNode newHead = new();
        ListNode newHead1 = newHead;

        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                ListNode newNode = new(list1.val);
                newHead.next = newNode;
                newHead = newNode;
                list1 = list1.next;
            }
            else {
                ListNode newNode = new(list2.val);
                newHead.next = newNode;
                newHead = newNode;
                list2 = list2.next;
            }
        }

        while(list1 != null){
            ListNode newNode = new(list1.val);
                newHead.next = newNode;
                newHead = newNode;
                list1 = list1.next;
        }

        while(list2 != null){
            ListNode newNode = new(list2.val);
                newHead.next = newNode;
                newHead = newNode;
                list2 = list2.next;
        }

        return newHead1.next;
    }
}