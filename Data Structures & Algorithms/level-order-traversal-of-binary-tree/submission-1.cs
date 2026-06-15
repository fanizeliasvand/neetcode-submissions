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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root != null) q.Enqueue(root);

        while(q.Count > 0)
        {
            List<int> curr = new List<int>();
            int level = q.Count; 
            for(int i = 0; i < level; i++)
            {
                TreeNode node = q.Dequeue();
                curr.Add(node.val);
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
            res.Add(curr);

        }
        return res; 
    }
}
