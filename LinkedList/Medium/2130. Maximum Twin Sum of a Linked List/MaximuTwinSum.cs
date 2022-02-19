/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
public int PairSum(ListNode head)
        {
            var dict = new Dictionary<int, int>();
            var n = 0;
            for(var tail = head; tail != null; tail = tail.next)
            {
                dict.Add(n++, tail.val);
            }
            int sum = 0, max = int.MinValue, a, b;
            for(int i=0;i<(n/2); i++)
            {
                var twin = n - i - 1;
                dict.TryGetValue(i, out  a);
                dict.TryGetValue(twin, out  b);
                sum = a + b;
                if(sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
}