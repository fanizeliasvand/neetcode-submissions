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
    public bool IsValidBST(TreeNode root) {
        IList<int> res = new List<int>(); 
        res = Traverse(root, res); 
        int previous = int.MinValue; 
        foreach(int num in res)
        {
            if (num <= previous) return false; 
            previous = num; 
        }
        return true; 
    }
    public IList<int> Traverse(TreeNode root, IList<int> res)
    {
        if(root == null) return null; 
        Traverse(root.left, res); 
        res.Add(root.val); 
        Traverse(root.right, res); 
        return res; 
    }
    
}
