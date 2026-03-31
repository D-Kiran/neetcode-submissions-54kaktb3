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
        ListNode i = list1;
        ListNode j = list2;
        var dummy = new ListNode();    

        ListNode output = dummy;

        while(i != null && j!= null){
            if(j.val < i.val){
                output.next = j;
                j=j.next;
            }
            else{
                output.next = i;
                i=i.next;
            }
            output = output.next;
        }
        
        if(i != null){
            output.next = i;
        }
        else{
            output.next =j;
        }   
        return dummy.next;
    }
}