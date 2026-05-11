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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, Int32.MinValue, Int32.MaxValue);
    }

    private bool IsValid(TreeNode root, int leftmost, int rightmost){
        if(root == null) return true;

        if(!(leftmost < root.val && rightmost > root.val)) return false;

        return IsValid(root.left,leftmost,root.val) && IsValid(root.right,root.val, rightmost);
    }
}
