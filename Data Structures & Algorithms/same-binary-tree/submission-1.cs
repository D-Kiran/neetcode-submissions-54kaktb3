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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if((p == null && q != null) || (p != null && q == null) ) return false;


        if(p == null && q == null) return true;

        var queue1 = new Queue<TreeNode>();
        var queue2 = new Queue<TreeNode>();

        queue1.Enqueue(p); queue2.Enqueue(q);

        while(queue1.Count >0 && queue2.Count > 0){

            if(queue1.Count != queue2.Count) return false;
            var p1 = queue1.Dequeue();
            var q1 = queue2.Dequeue();

            if(p1.val != q1.val) return false;

            if(p1.left != null && q1.left == null || p1.left == null && q1.left != null) return false;
             if(p1.right != null && q1.right == null || p1.right == null && q1.right != null) return false;

            if(p1.left != null) queue1.Enqueue(p1.left);
            if(p1.right != null) queue1.Enqueue(p1.right);
            if(q1.left != null) queue2.Enqueue(q1.left);
            if(q1.right != null) queue2.Enqueue(q1.right);
        }

        return true;
    }
}
