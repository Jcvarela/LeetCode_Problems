public class LinkedListCycle0141
{
    public static bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
            return false;

        var slow = head;
        var fast = head.next;

        while (slow != fast)
        {
            if (fast == null || fast.next == null)
            {
                return false;
            }

            slow = slow.next;
            fast = fast.next.next;

        }
        return true;
    }
}