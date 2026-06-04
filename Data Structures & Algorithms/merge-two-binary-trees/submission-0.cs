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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        TreeNode head = new TreeNode();
        if(root1 != null && root2 != null) 
        {
            head.val = root1.val + root2.val;
        }
        else if(root1 == null) return root2;
        else if(root2 == null) return root1;
        else return null; 
        head.left = MergeTrees(root1.left, root2.left);
        head.right = MergeTrees(root1.right, root2.right);


        return head; 
    }
}