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
    public ListNode AddToLinkedList(ListNode head, int data)
        {
            if (head == null)
            {
                head = new ListNode(data, null);
                return head;
            }
            var tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = new ListNode(data, null);
            return head;
        }
public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = null;
            ListNode tail, tail1 = list1, tail2 = list2;
            while(tail1 != null || tail2 != null)
            {
                if(tail1 == null)
                {
                    while(tail2 != null)
                    {
                        head = AddToLinkedList(head, tail2.val);
                        tail2 = tail2.next;
                    }
                    break;
                }

                if (tail2 == null)
                {
                    while (tail1 != null)
                    {
                        head = AddToLinkedList(head, tail1.val);
                        tail1 = tail1.next;
                    }
                    break;
                }
                if (tail1.val <= tail2.val)
                {
                    head = AddToLinkedList(head, tail1.val);
                    tail1 = tail1.next;
                }
                else
                {
                    head = AddToLinkedList(head, tail2.val);
                    tail2 = tail2.next;
                }
            }
            return head;
        }
}