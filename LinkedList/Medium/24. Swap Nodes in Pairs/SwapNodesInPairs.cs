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
    public ListNode SwapPairs(ListNode head)
        {
            ListNode tail1 = head;
            if (tail1 == null)
            {
                return null;
            }
            ListNode tail2 = tail1.next;
            ListNode prev = null;

            while(tail1 != null && tail2 != null)
            {
                tail1.next = tail2.next;
                tail2.next = tail1;
                if(prev == null)
                {
                    head = tail2;
                }
                else
                {
                    prev.next = tail2;
                }
                prev = tail1;
                tail1 = tail1.next;
                if(tail1 == null || tail1.next == null)
                {
                    break;
                }
                tail2 = tail1.next;
            }
            return head;
        }
}