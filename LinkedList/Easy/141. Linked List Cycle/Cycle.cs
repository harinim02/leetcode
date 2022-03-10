/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
public bool HasCycle(ListNode head)
        {
            ListNode fast = head, slow = head;
            while(fast != null && slow!=null && slow.next != null)
            {
                fast = fast.next;
                slow = slow.next.next;
                if(fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
}