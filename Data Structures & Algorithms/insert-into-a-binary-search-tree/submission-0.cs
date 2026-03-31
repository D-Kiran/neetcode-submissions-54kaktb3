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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        root = Insert(root,val);
        return root;
    }

    private TreeNode Insert(TreeNode x, int val){
        if(x == null) return new TreeNode(val);

        if(val < x.val){
            x.left = Insert(x.left,val);
        }
        else if(val > x.val){
            x.right = Insert(x.right,val);
        }
        return x;
    }
}