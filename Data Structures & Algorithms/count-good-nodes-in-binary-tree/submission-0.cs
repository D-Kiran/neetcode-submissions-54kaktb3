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
    private int Count =0;

    public int GoodNodes(TreeNode root) {
        Dfs(root, root.val);
        return Count;
    }

    private void Dfs(TreeNode root, int highestval){
        if(root == null) return;
        if(root.val >= highestval){
            Count++;
            highestval = root.val;
        }
        Dfs(root.left,highestval);
        Dfs(root.right, highestval);
    }
}
