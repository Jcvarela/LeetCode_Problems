using System.Collections.Generic;
using Xunit;

namespace LeetCode_Problems.Status_EASY.L0163_MissingRanges
{
    public class L0163_MissingRangesTest
    {

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { new int[] { }, 0, 99, new int[][] { new int[] { 0, 99 } } };
            yield return new object[] { new int[] { 0, 1, 3, 50, 75 }, 0, 99, new int[][] { new int[] { 2, 2 }, new int[] { 4, 49 }, new int[] { 51, 74 }, new int[] { 76, 99 } } };
            yield return new object[] { new int[] { 1, 3, 50, 75 }, 0, 99, new int[][] { new int[] { 0, 0 }, new int[] { 2, 2 }, new int[] { 4, 49 }, new int[] { 51, 74 }, new int[] { 76, 99 } } };
            yield return new object[] { new int[] { 0, 1, 3, 50, 75 }, 0, 75, new int[][] { new int[] { 2, 2 }, new int[] { 4, 49 }, new int[] { 51, 74 } } };
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void FindMissingRanges_Test(int[] nums, int lower, int upper, int[][] expected)
        {
            var result = MissingRanges.FindMissingRanges(nums, lower, upper);
            Assert.Equal(expected.Length, result.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}