/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
       Stack<TreeNode> stack = new();
       var current = root;

       while(stack.Count >0 || current != null){
         while(current != null){
            stack.Push(current);
            current = current.left;
         }
         current = stack.Pop();
         k--;
         if(k == 0) return current.val;
         current = current.right;
       }

       return -1;

    }
}
