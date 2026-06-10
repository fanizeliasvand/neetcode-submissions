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
    public int KthSmallest(TreeNode root, int k) {
        IList<int> res = new List<int>();
        res = Traverse(root, res); 
        return res[k-1];        
    }
    public IList<int> Traverse(TreeNode root, IList<int> res)
    {
        if(root == null) return res;
        Traverse(root.left, res);
        res.Add(root.val);
        Traverse(root.right, res);
        return res; 
    }
}
