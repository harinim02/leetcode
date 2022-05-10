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
private void SwapNodes(ListNode p, ListNode q)
        {
            var temp = p.val;
            p.val = q.val;
            q.val = temp;
        } 

        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode p = head, q = head, tail = head;
            if(head == null || head.next == null)
            {
                return head;
            }
            k = k - 1;
            while (tail != null && k-- > 0)
            {
                tail = tail.next;
                p = p.next;
            }
            while(tail.next!= null)
            {
                tail = tail.next;
                q = q.next;
            }
            if(p == null || q == null)
            {
                return head;
            }
            SwapNodes(p, q);
            return head;
        }
}