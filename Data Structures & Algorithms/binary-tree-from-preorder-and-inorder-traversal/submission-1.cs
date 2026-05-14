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
    private Dictionary<int,int> dict = new();
     int preidx = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i=0; i<inorder.Length;i++){
            dict[inorder[i]] = i;
        }
        return Dfs(preorder,0, inorder.Length-1);
    }

    private TreeNode Dfs(int[] preorder, int left, int right){
        if(left > right) return null;
        int rootval = preorder[preidx++];
        int mid = dict[rootval];
        var root = new TreeNode(rootval);
        root.left = Dfs(preorder,left,mid-1);
        root.right = Dfs(preorder,mid+1,right);
        return root;
    }
}
