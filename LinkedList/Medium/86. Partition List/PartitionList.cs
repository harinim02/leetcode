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
 public ListNode Partition(ListNode head, int x)
        {
            ListNode lessList = null, moreList = null, tail = null;
            if(head == null || head.next == null){
                return head;
            }

            for(tail = head;  tail != null; tail = tail.next)
            {
                if(tail.val < x)
                {
                    lessList = lessList == null ? new ListNode(tail.val):AddToLinkedList(lessList, tail.val);
                    
                }
                else
                {
                    moreList = moreList == null ? new ListNode(tail.val):AddToLinkedList(moreList, tail.val);
                    
                }
            }

            if (lessList == null)
            {
                return moreList;
            }

            for (tail = lessList; tail.next!=null;)
            {
                tail = tail.next;
            }
            
            tail.next = moreList;
            return lessList;
            
        }
}