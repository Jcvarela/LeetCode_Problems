using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0033_SearchInRotatedSortedArray
{
    public class L_0033_SearchInRotatedSortedArrayTest
    {
        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new int[] { 1 }, 0, -1)]
        [InlineData(new int[] { 1, 3 }, 3, 1)]
        [InlineData(new int[] { 5, 1, 3 }, 5, 0)]
        [InlineData(new int[] { 5, 1, 3 }, 1, 1)]
        [InlineData(new int[] { 5, 1, 3 }, 3, 2)]
        public void Search_Test(int[] nums, int target, int expected)
        {
            int result = L_0033_SearchInRotatedSortedArray.Search(nums, target);
            Assert.Equal(expected, result);
        }
    }
}