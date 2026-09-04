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

public class Solution 
{
public bool IsBalanced (TreeNode root)
{
if(dfs(root) == -1) return false;
return true; 
}
private int dfs(TreeNode node)
{
if(node == null) return 0; 
int left = dfs(node.left); 
int right = dfs(node.right); 

if(left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1; 


return 1 + Math.Max(left, right); 
}





}