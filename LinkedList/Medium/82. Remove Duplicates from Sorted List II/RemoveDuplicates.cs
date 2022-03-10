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
public ListNode DeleteDuplicates(ListNode head)
        {
            var dict = new Dictionary<int, int>();
            ListNode tail = head;
            int count;
            if(head == null)
            {
                return head;
            }
            for(tail = head; tail != null;tail=tail.next)
            {
                dict.TryGetValue(tail.val, out count);
                dict[tail.val] = count + 1;
            }
            ListNode prev = head;
            // Duplicate is head
            // Duplicate in mid
            // Duplicate is
            
            tail = head; 
            while(tail != null)
            {
                dict.TryGetValue(tail.val, out count);
                if(count > 1)
                {
                    // is a duplicate entry
                    if(tail == head)
                    {
                        // duplicate is a head
                        head = head.next;
                        prev = tail = head;
                    }
                    else
                    {
                        int currentValue = tail.val;
                        while(tail !=null && tail.val == currentValue)
                        {
                            prev.next = tail.next;
                            tail = prev.next;
                            
                        }
                    }
                }
                else
                {
                    prev = tail;
                    tail = tail.next;
                }
            }
            return head;
        }
}