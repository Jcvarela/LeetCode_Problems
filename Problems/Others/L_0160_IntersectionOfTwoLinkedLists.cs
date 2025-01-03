public class IntersectionOfTwoLinkedLists0160
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
            return null;

        var pointerA = headA;
        var pointerB = headB;

        while (pointerA != pointerB)
        {
            pointerA = (pointerA == null) ? headB : pointerA.next;
            pointerB = (pointerB == null) ? headA : pointerB.next;
        }

        return pointerA;
    }
}