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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> queue = new();
        if(root != null) queue.Enqueue(root);

        var output = new List<List<int>>();

        while(queue.Count > 0){
            int levelLength = queue.Count;
           List<int> levelNodes = new();
            for(int i = 0; i<levelLength;i++){
              var current = queue.Dequeue();
              levelNodes.Add(current.val);
              if(current.left != null) queue.Enqueue(current.left);
              if(current.right != null) queue.Enqueue(current.right);
            }
            output.Add(levelNodes);
        }
        return output;
    }
}
