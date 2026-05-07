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
         
        var result = new List<List<int>>();
        var queue = new Queue<TreeNode>();

        if(root == null) return result;

        result.Add(new List<int>(){root.val});

        queue.Enqueue(root);

        while(queue.Count > 0){
            int size = queue.Count;
            var list = new List<int>();

            for(int i=0; i<size; i++){
                var node = queue.Dequeue();
                

                if(node.left != null){
                    queue.Enqueue(node.left);
                    list.Add(node.left.val);
                }
                if(node.right != null){
                    queue.Enqueue(node.right);
                    list.Add(node.right.val);
                } 
            }

            if(list.Count >0) result.Add(list);


        }

        return result;
    }
}
