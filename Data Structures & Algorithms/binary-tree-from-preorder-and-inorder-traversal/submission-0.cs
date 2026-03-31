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

    private int preIndex= 0;
    private Dictionary<int,int> indices = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
      
        for(int k=0; k<inorder.Length;k++){
            indices.Add(inorder[k],k);
        }
        return Dfs(preorder, 0, inorder.Length-1);
    }

    private TreeNode Dfs(int[] preorder, int lo, int hi){
        if(hi<lo) return null;
        int rootVal = preorder[preIndex++];
        TreeNode node = new(rootVal);
        int mid = indices[rootVal];
        node.left = Dfs(preorder,lo,mid-1);
        node.right = Dfs(preorder,mid+1,hi);
        return node;
    }
}
