
public ListNode RotateRight(ListNode head, int k)
        {
            ListNode tail, prev;
            if(head == null || head.next == null)
            {
                return head;
            }

            // Find LL length

            int length = 0;
            for(tail = head;tail!=null;tail = tail.next)
            {
                length++;
            }

            k %= length;

            while(k-- > 0)
            {
                tail = prev = head;
                while(tail.next != null)
                {
                    prev = tail;
                    tail = tail.next;
                }

                prev.next = null;
                tail.next = head;
                head = tail;
            }

            return head;
        }