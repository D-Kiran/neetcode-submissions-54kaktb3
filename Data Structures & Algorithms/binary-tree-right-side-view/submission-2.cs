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
    public List<int> RightSideView(TreeNode root) {
        
        var result = new List<int>();
        if(root == null) return result;
        result.Add(root.val);

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);


        while(queue.Count > 0){
            int size = queue.Count;
            var list = new List<int>();

            for(int i=0;i<size;i++){
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
           if(list.Count > 0) result.Add(list[list.Count-1]);
        }

        return result;
    }
}
