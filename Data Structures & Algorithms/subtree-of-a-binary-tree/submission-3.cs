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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null) return false; 
        if (IsSameTree(root, subRoot)) return true; 
        bool lookRight = IsSubtree(root.right, subRoot);
        bool lookLeft = IsSubtree(root.left, subRoot);
        return lookRight || lookLeft;
    }
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true; 
        if(p == null || q == null) return false; 
        if(p.val != q.val) return false; 
        bool rightCheck = IsSameTree(p.right, q.right);
        bool leftCheck = IsSameTree(p.left, q.left);
        return rightCheck && leftCheck; 
    }
}
