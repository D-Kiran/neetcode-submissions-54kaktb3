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
    public List<int> InorderTraversal(TreeNode root) {
        var output = new List<int>();
       InOrderTraversal(root,output);
       return output;    

    }

    private void InOrderTraversal(TreeNode x, List<int> output){
        if(x == null) return;
        InOrderTraversal(x.left,output);
        output.Add(x.val);
        InOrderTraversal(x.right,output);
    }
}