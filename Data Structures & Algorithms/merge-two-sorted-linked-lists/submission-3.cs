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
            ListNode newNode = new();
            if(list1.val <= list2.val){
                 newNode.val = list1.val;   
                list1 = list1.next;
            }
            else {
                newNode.val = list2.val;
                list2 = list2.next;
            }
            newHead.next = newNode;
            newHead = newNode;
        }

        if(list1 != null){
            newHead.next = list1;
        }

        if(list2 != null){
            
            newHead.next = list2;
               
        }

        return newHead1.next;
    }
}