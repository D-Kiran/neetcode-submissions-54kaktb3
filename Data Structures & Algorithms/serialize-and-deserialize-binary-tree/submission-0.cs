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

public class Codec {

    private List<String> result = new();
    private string[] output;
    private int index = 0;

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        Dfs(root);
        return string.Join(",",result.ToArray());        
    }

    private void Dfs(TreeNode root){
        if(root == null){
             result.Add("N");
             return;
        }
        result.Add(root.val.ToString());

        Dfs(root.left);
        Dfs(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        output = data.Split(",");
        return Dfs();
    }   

    private TreeNode Dfs(){
        if(output[index] == "N"){
            index++;
            return null;
        }

        var node = new TreeNode(int.Parse(output[index]));
        index++;
        node.left = Dfs();
        node.right = Dfs();
        return node;
    }
}
