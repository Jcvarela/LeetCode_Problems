using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0991_BrokenCalculator
{
    public class L_0991_BrokenCalculatorTest
    {
        [Theory]
        [InlineData(2, 3, 2)]
        [InlineData(5, 8, 2)]
        [InlineData(3, 10, 3)]
        [InlineData(1024, 1, 1023)]
        [InlineData(1, 1000000000, 39)]
        [InlineData(7, 20, 4)]
        public void BrokenCalc_Test(int startValue, int target, int expected)
        {
            int result = new L_0991_BrokenCalculator().BrokenCalc(startValue, target);
            Assert.Equal(expected, result);

        }
    }
}