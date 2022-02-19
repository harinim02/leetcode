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
    public int DeepestLeavesSum(TreeNode root)
        {
            return GetDeepestChildrenSum(root, Height(root), 0);
        }

        private int GetDeepestChildrenSum(TreeNode root, int level, int sum)
        {
            if(root == null)
            {
                return sum;
            }
            if(level == 1)
            {
                sum += root.val;
            }
            else if(level > 1)
            {
                return GetDeepestChildrenSum(root.left, level - 1, sum)
                    + GetDeepestChildrenSum(root.right, level - 1, sum);
            }
            return sum;
        }
    private int Height(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            int left = Height(root.left);
            int right = Height(root.right);
            return left > right ? left + 1 : right + 1;
        }
}