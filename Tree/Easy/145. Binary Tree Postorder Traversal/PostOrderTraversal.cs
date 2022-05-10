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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            PostOrderRecur(root, output);
            return output;
        }

        private void PostOrderRecur(TreeNode root, IList<int> output)
        {
            if(root == null)
            {
                return;
            }
            PostOrderRecur(root.left, output);
            PostOrderRecur(root.right, output);
            output.Add(root.val);
        }
}