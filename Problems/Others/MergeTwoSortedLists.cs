public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode resultHead = new ListNode();
        ListNode resultPointer = resultHead;
        ListNode list1Pointer = list1;
        ListNode list2Pointer = list2;

        while (list1Pointer != null && list2Pointer != null)
        {
            if (list1Pointer.val < list2Pointer.val)
            {
                resultPointer.next = new ListNode(list1Pointer.val);
                list1Pointer = list1Pointer.next;
            }
            else
            {
                resultPointer.next = new ListNode(list2Pointer.val);
                list2Pointer = list2Pointer.next;
            }
            resultPointer = resultPointer.next;
        }

        resultPointer.next = list1Pointer ?? list2Pointer;

        return resultHead.next;
    }
}