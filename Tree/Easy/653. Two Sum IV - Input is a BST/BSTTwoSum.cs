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
    public bool FindTarget(TreeNode root, int k)
        {
            return FindTargetSearch(root, k, root);
        }

        public bool FindTargetSearch(TreeNode root, int k, TreeNode current)
        {
            // search for k-root->val
            // search root->left
            // search root->right
            if (current == null)
            {
                return false;
            }
            return BinaryTreeSearch(root, k - current.val, current) 
                || FindTargetSearch(root, k, current.left) 
                || FindTargetSearch(root, k, current.right);
        }
        public bool BinaryTreeSearch(TreeNode root, int num, TreeNode exclude)
        {
            if(root == null)
            {
                return false;
            }
            return (root != exclude && root.val == num)
                    || (root.val > num && BinaryTreeSearch(root.left, num, exclude))
                    || (root.val < num && BinaryTreeSearch(root.right, num, exclude));
        }
}