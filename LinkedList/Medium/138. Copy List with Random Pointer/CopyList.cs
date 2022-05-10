/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
 public Node CopyRandomList(Node head)
        {
            Node tail = head;
            if (head == null)
            {
                return head;
            }
            while (tail != null)
            {
                var newNode = new Node(tail.val);
                newNode.next = tail.next;
                tail.next = newNode;
                tail = newNode.next;
            }

            tail = head;
            while (tail != null)
            {
                tail.next.random = tail.random == null ? null : tail.random.next;
                tail = tail.next.next;
            }

            Node newHead = head.next;
            Node newtail = head.next;
            tail = head;
            while (tail != null)
            {
                tail.next = tail.next.next;
                newtail.next = newtail.next == null ? null : newtail.next.next;
                tail = tail.next;
                newtail = newtail.next;
            }
            return newHead;
        }
}