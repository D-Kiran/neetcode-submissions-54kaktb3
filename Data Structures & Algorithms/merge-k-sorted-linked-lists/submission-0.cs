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
    public ListNode MergeKLists(ListNode[] lists) {

        if(lists.Length == 0) return null;

        for(int i=1; i<lists.Length; i++){
            lists[i] = Merge(lists[i], lists[i-1]);
        }

        return lists[lists.Length-1];
        //return finalresult[0];

    }


    private ListNode Merge(ListNode first, ListNode second){

        var result = new ListNode(0);
        var dummy = result;


        while(first != null && second != null)
        {
              int val1 = first.val;
              int val2 = second.val;
              if(val1 <= val2)
              {
                  var newNode = new ListNode(val1);
                  result.next = newNode;
                  result = newNode;
                  first= first.next;
              }
              else
              {
                var newNode = new ListNode(val2);
                  result.next = newNode;
                  result = newNode;
                  second= second.next;
              }
        }

        if(first != null){
           result.next = first;
        }

        if(second != null){
            result.next = second;
        }

        return dummy.next;
    }
}
