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
        var node = Select(root,k-1);
        return node.val;
    }

    private TreeNode Select(TreeNode x, int k){
        if(x == null) return null;
        int t = Size(x.left);
        if(t > k) return Select(x.left,k);
        else if(t < k) return Select(x.right,k-t-1);
        else return x;
    }

    private int Size(TreeNode x){
        if(x == null) return 0;
        return 1 + Size(x.left)+Size(x.right);
    }
}
