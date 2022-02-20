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
public ListNode MergeNodes(ListNode head)
        {
            var tail = head.next;
            var next = tail.next;
            while(tail.next != null)
            {
                while(next.val != 0)
                {
                    tail.val += next.val;
                    tail.next = next.next;
                    next = tail.next;
                }
                if(next.next == null)
                {
                    // You have reached the last node
                    tail.next = null;
                }
                else
                {
                    tail = next;
                    next = tail.next;
                }
            }
            head = head.next;
            return head;
        }
}