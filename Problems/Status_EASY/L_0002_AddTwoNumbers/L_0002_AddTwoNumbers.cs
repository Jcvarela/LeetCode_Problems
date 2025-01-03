// Problem: https://leetcode.com/problems/add-two-numbers/description/

// You are given two non-empty linked lists representing two non-negative integers. 
// The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

namespace LeetCode_Problems.Problems.Status_EASY.L_0002_AddTwoNumbers
{
    public class L_0002_AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultHead = new ListNode();
            ListNode resultPointer = resultHead;

            int carry = 0;
            while (l1 != null || l2 != null)
            {
                resultPointer.next = new ListNode();
                resultPointer = resultPointer.next;
                int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;

                resultPointer.val = sum % 10;

                carry = sum / 10;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            if (carry > 0)
            {
                resultPointer.next = new ListNode(carry);
            }

            return resultHead.next;
        }
    }
}