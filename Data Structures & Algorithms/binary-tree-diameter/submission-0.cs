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
    public int DiameterOfBinaryTree(TreeNode root) {
          int result =0;

          Dfs(root,ref result);
          return result;
    }

    private int Dfs(TreeNode root, ref int result)
    {
        if( root == null) return 0;

        var leftheight = Dfs(root.left,ref result);
        var rightheight = Dfs(root.right, ref result);

        result = Math.Max(result, leftheight+rightheight);
        return 1 + Math.Max(leftheight,rightheight);
    }
}
