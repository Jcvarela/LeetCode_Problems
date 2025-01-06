using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0191_NumberOf1Bits
{
    public class L_0191_NumberOf1BitsTest
    {
        [Theory]
        [InlineData(11, 3)] // 1011 in binary has 3 set bits
        [InlineData(128, 1)] // 10000000 in binary has 1 set bit
        [InlineData(255, 8)] // 11111111 in binary has 8 set bits
        [InlineData(0, 0)] // 0 in binary has 0 set bits
        [InlineData(1, 1)] // 1 in binary has 1 set bit
        public void HammingWeight_TestCases(int n, int expected)
        {
            int result = L_0191_NumberOf1Bits.HammingWeight(n);
            Assert.Equal(expected, result);
        }
    }
}