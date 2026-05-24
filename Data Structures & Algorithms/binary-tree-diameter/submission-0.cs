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
    public int longest = 0; 
    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return longest; 
    }
    public int Dfs(TreeNode root)
    {
        if(root == null) return 0; 

        int rightHeight = Dfs(root.right);
        int leftHeight = Dfs(root.left);
        int temp = rightHeight + leftHeight;
        this.longest = Math.Max(temp, longest);
        return Math.Max(rightHeight, leftHeight) + 1; 
    }
}
