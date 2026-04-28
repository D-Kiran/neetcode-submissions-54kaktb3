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

        while(lists.Length >1){
            List<ListNode> mergedLists = new();
            for(int i=0; i<lists.Length;i+=2){
                var list1 = lists[i];
                var list2 =  (i+1 < lists.Length) ? lists[i+1]: null;
                mergedLists.Add(Merge(list1,list2));
            }
            lists = mergedLists.ToArray();
        }
        return lists[0];

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
