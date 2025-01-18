
using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_2164_SortEvenAndOddIndicesIndependently
{

    public class L_2164_SortEvenAndOddIndicesIndependentlyTest
    {
        [Theory]
        [InlineData(new int[] { 4, 1, 2, 3 }, new int[] { 2, 3, 4, 1 })]
        [InlineData(new int[] { 2, 1 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 2 }, new int[] { 2 })]
        [InlineData(new int[] { 4, 1, 2, 3, 5 }, new int[] { 2, 3, 4, 1, 5 })]
        public void Test1(int[] input, int[] expected)
        {
            var result = L_2164_SortEvenAndOddIndicesIndependently.SortEvenOdd(input);
            Assert.Equal(expected, result);
        }

    }
}