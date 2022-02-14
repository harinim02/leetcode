public ListNode OddEvenList(ListNode head)
        {
            if(head == null)
            {
                return head;
            }
            int length = 0;
            var tail = head;
            while(tail.next != null)
            {
                length++;
                tail = tail.next;
            }
            length++;
            if(length < 3)
            {
                return head;
            }
            ListNode odd, even;
            odd = head;
            even = odd.next;
            var l = length / 2;

            while(l-- > 0 && odd!=null && even != null)
            {
                odd.next = even.next;
                tail.next = even;
                tail = tail.next;
                even.next = null;
                odd = odd.next;
                if (odd.next != null)
                {
                    even = odd.next;
                }
                else
                {
                    break;
                }
                
            }

            return head;
        }