using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0075_SortColors
{
    public class L_0075_SortColorsTest
    {
        [Theory]
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2, 2 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        public void SortColors_TestCases(int[] nums, int[] expected)
        {
            L_0075_SortColors.SortColors(nums);
            Assert.Equal(expected, nums);
        }
    }
}