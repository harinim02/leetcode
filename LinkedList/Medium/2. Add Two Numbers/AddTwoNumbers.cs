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

        public ListNode ReverseLL(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            ListNode curr, prev, next;
            curr = next = head;
            prev = null;
            while(next != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }

        public ListNode AddTwoNumbers(ListNode head1, ListNode head2)
        {
           // head1 = ReverseLL(head1);
           // head2 = ReverseLL(head2);
            int sum = 0, carry = 0;
            ListNode resultHead = null;
            while(head1!=null && head2 != null)
            {
                sum = head1.val + head2.val + carry;
                carry = sum / 10;
                sum = sum % 10;
                head1 = head1.next;
                head2 = head2.next;
                if(resultHead == null)
                {
                    resultHead = new ListNode(sum, null);
                }
                else
                {
                    AddToLinkedList(resultHead, sum);
                }
            }
            while(head1 != null)
            {
                sum = head1.val + carry;
                carry = sum / 10;
                sum = sum % 10;
                AddToLinkedList(resultHead, sum);
                head1 = head1.next;
            }

            while (head2 != null)
            {
               sum = head2.val + carry;
                carry = sum / 10;
                sum = sum % 10;
                AddToLinkedList(resultHead, sum);
                head2 = head2.next;
            }
            if(carry!=0){
                AddToLinkedList(resultHead, carry);
            }
            //return ReverseLL(resultHead);
            return resultHead;
        }
    
}