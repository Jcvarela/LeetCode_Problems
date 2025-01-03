public class AddTwoNumbers02
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultHead = new ListNode();
        ListNode resultPointer = resultHead;

        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;

            resultPointer.val = sum % 10;
            resultPointer.next = new ListNode();
            resultPointer = resultPointer.next;

            carry = sum / 10;

            l1 = l1.next;
            l2 = l2.next;
        }

        return resultHead;
    }
}