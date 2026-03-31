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
    public TreeNode DeleteNode(TreeNode root, int key) {
        return Delete(root,key);
    }
    private TreeNode Delete(TreeNode x, int key){
        if(x == null) return null;
        if(key< x.val) x.left = Delete(x.left,key);
        else if(key > x.val) x.right = Delete(x.right,key);
        else{
            if(x.left == null) return x.right;
            if(x.right == null) return x.left;
            TreeNode t = x;
            x = Minimum(t.right);
            x.right = DeleteMin(t.right);
            x.left = t.left; 
        }
        return x;
    }

    private TreeNode Minimum(TreeNode x){
        if(x.left == null) return x;
        return Minimum(x.left);
    }

    private TreeNode DeleteMin(TreeNode x){
        if(x.left == null) return x.right;
        x.left = DeleteMin(x.left);
        return x;
    }
}