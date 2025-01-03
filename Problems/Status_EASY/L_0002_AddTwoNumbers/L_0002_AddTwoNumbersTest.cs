using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0002_AddTwoNumbers
{
    public class L_0002_AddTwoNumbersTest
    {
        [Fact]
        public void AddTwoNumbers_ReturnsCorrectResult_ForSimpleCase()
        {
            // Arrange
            var l1 = CreateListNode(new int[] { 2, 4, 3 }); // Represents 342
            var l2 = CreateListNode(new int[] { 5, 6, 4 }); // Represents 465
            var expected = CreateListNode(new int[] { 7, 0, 8 }); // Represents 807

            // Act
            var result = L_0002_AddTwoNumbers.AddTwoNumbers(l1, l2);

            // Assert
            AssertNodeAreEqual(expected, result);
        }

        [Fact]
        public void AddTwoNumbers_ReturnsCorrectResult_WithCarryOver()
        {
            // Arrange
            var l1 = CreateListNode(new int[] { 9, 9 }); // Represents 99
            var l2 = CreateListNode(new int[] { 1 });    // Represents 1
            var expected = CreateListNode(new int[] { 0, 0, 1 }); // Represents 100

            // Act
            var result = L_0002_AddTwoNumbers.AddTwoNumbers(l1, l2);

            // Assert
            AssertNodeAreEqual(expected, result);
        }

        [Fact]
        public void AddTwoNumbers_ReturnsCorrectResult_WithUnequalLengthLists()
        {
            // Arrange
            var l1 = CreateListNode(new int[] { 1, 8 }); // Represents 81
            var l2 = CreateListNode(new int[] { 0 });    // Represents 0
            var expected = CreateListNode(new int[] { 1, 8 }); // Represents 81

            // Act
            var result = L_0002_AddTwoNumbers.AddTwoNumbers(l1, l2);

            // Assert
            AssertNodeAreEqual(expected, result);
        }

        // Helper Methods
        private void AssertNodeAreEqual(ListNode expected, ListNode result)
        {
            while (expected != null && result != null)
            {
                Assert.Equal(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            Assert.Null(expected);
            Assert.True(result == null || result.val == 0);
        }

        private ListNode CreateListNode(int[] values)
        {
            var dummyHead = new ListNode();
            var current = dummyHead;
            foreach (var val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummyHead.next;
        }

        private bool AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val) return false;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }
    }
}