using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_1283_FindTheSmallestDivisorGivenAThreshold
{
    public class L_1283_FindTheSmallestDivisorGivenAThresholdTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 5, 9 }, 6, 5)]
        [InlineData(new int[] { 2, 3, 5, 7, 11 }, 11, 3)]
        [InlineData(new int[] { 19 }, 5, 4)]
        [InlineData(new int[] { 1, 2, 3 }, 6, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 3, 3)]
        public void SmallestDivisor_Test(int[] nums, int threshold, int expected)
        {
            int result = new L_1283_FindTheSmallestDivisorGivenAThreshold().SmallestDivisor(nums, threshold);
            Assert.Equal(expected, result);
        }
    }
}