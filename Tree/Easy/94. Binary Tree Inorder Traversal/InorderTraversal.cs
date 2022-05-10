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
public IList<int> InorderTraversal(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var output = new List<int>();
            if(root == null)
            {
                return output;
            }
            var node = root;
            while(node !=null || stack.Count > 0)
            {
                while(node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                node = stack.Pop();
                output.Add(node.val);
                node = node.right;
            }
            return output;
        }
}