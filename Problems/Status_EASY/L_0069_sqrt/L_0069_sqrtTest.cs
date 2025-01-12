using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0069_sqrt
{
    public class L_0069_sqrtTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        [InlineData(2147395599, 46339)]
        public void MySqrt_Test(int x, int expected)
        {
            int result = L_0069_sqrt.MySqrt(x);
            Assert.Equal(expected, result);
        }
    }
}