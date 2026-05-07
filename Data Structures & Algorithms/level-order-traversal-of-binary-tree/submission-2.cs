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

    List<List<int>> result = new List<List<int>>();

    public List<List<int>> LevelOrder(TreeNode root) {
         
        Dfs(root,0);
        return result;
        
    }

    private void Dfs(TreeNode root, int depth){
        if(root == null) return;

        if(result.Count == depth){
            result.Add(new List<int>());
        }

        result[depth].Add(root.val);
        Dfs(root.left,depth+1);
        Dfs(root.right, depth+1);
    }
}
