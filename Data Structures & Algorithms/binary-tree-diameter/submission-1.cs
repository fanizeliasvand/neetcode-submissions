public class Solution 
{
public int longest = 0; 
public int DiameterOfBinaryTree(TreeNode root)
{
dfs(root); 

return longest; 
}
private int dfs(TreeNode node)
{
  if(node == null) return 0; 

int left = dfs(node.left); 
int right = dfs(node.right);
longest = Math.Max(longest, left + right); 

return 1 + Math.Max(left, right); 
}
}