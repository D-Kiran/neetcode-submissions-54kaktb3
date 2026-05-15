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
    public int MaxPathSum(TreeNode root) {

        int result = root.val;
        Dfs(root,ref result);
        return result;
    }

    private int Dfs(TreeNode root, ref int result){
        if(root == null) return 0;

        int leftmax = Dfs(root.left, ref result);
        int rightmax = Dfs(root.right, ref result);

        leftmax = Math.Max(leftmax,0);
        rightmax = Math.Max(rightmax,0);

        result = Math.Max(result, root.val + leftmax + rightmax);

        return root.val + Math.Max(leftmax,rightmax);
    }
}
