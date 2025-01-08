using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0070_ClimbingStairs
{
    public class L_0070_ClimbingStairsTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(5, 8)]
        [InlineData(6, 13)]
        public void ClimbStairs_Test(int n, int expected)
        {
            var solution = new L_0070_ClimbingStairs();
            int result = solution.ClimbStairs(n);
            Assert.Equal(expected, result);
        }
    }
}