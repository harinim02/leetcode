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
public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> output = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            int levelCount = 1;
            if(root == null)
            {
                return output;
            }
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                int currLevel = 0;
                var currList = new List<int>();
                while(levelCount > 0)
                {
                    var node = queue.Dequeue();
                    levelCount--;
                    currList.Add(node.val);
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                        currLevel++;
                    }
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                        currLevel++;
                    }
                }
                levelCount = currLevel;
                output.Add(currList);
            }
            return output;
        }
}