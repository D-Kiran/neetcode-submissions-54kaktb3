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

    private int sum = 0;
    private  int target;
    public bool HasPathSum(TreeNode root, int targetSum) {
        target = targetSum;
      return HasTargetSum(root);
    }

    private bool HasTargetSum(TreeNode x){
        if(x is null) return false;
        sum+=x.val;

        if(x.left is null && x.right is null && sum == target) return true;
        if(HasTargetSum(x.left)) return true;
        if(HasTargetSum(x.right)) return true;
        sum -= x.val;
        return false;
    }
}