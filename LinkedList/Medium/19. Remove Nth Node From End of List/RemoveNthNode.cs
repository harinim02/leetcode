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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
            {
                return head;
            }
            ListNode tail, prev, delNode;
            tail = prev = delNode = head;
            while(tail.next != null && n>1)
            {
                tail = tail.next;
                n--;
            }
            while(tail.next != null)
            {
                tail = tail.next;
                prev = delNode;
                delNode = delNode.next;
            }
            if(delNode == head)
            {
                head = head.next;
                return head;
            }
            prev.next = delNode.next;
            return head;
        }
}