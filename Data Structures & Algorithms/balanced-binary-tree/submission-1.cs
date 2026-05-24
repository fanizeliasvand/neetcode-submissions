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
    public bool IsBalanced(TreeNode root) {
        return dfs(root) != -1; 
    }
    public int dfs(TreeNode root){
        if(root == null) return 0; 

        int rightMaxDepth = dfs(root.right);
        if(rightMaxDepth == -1) return -1; 
        int leftMaxDepth = dfs(root.left);
        if(leftMaxDepth == -1) return -1; 

        if(Math.Abs(leftMaxDepth - rightMaxDepth) > 1)
        {
            return -1; 
        }

        return 1 + Math.Max(rightMaxDepth, leftMaxDepth); 
    }

}
