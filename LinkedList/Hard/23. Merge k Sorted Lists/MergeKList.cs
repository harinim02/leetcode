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
    private ListNode AddToLinkedList(ListNode head, int data)
        {
            if (head == null)
            {
                head = new ListNode(data);
                return head;
            }
            var tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = new ListNode(data);
            return head;
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            var list = new List<int>();
            for(int i = 0; i < lists.Length; i++)
            {
                for(var tail = lists[i];tail!=null;tail = tail.next)
                {
                    list.Add(tail.val);
                }
            }
            list.Sort();
            ListNode head = null;
            foreach (var item in list)
            {
                head = AddToLinkedList(head, item);
            }
            return head;
        }
}