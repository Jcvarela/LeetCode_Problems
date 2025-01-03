public class ReverseLinkedList_0206
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var next = head.next;
        head.next = null;
        while (next != null)
        {
            ListNode temp = next.next;
            next.next = head;
            head = next;
            next = temp;
        }

        return head;
    }
}