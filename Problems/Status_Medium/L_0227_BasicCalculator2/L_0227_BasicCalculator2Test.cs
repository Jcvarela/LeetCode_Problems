using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0227_BasicCalculator2
{
    public class L_0227_BasicCalculator2Test
    {
        [Theory]
        [InlineData("3+2*2", 7)]
        [InlineData(" 3/2 ", 1)]
        [InlineData(" 3+5 / 2 ", 5)]
        [InlineData("10-2*3", 4)]
        [InlineData("14/3*2", 8)]
        public void Calculate_Test(string input, int expected)
        {
            int result = L_0227_BasicCalculator2.Calculate(input);
            Assert.Equal(expected, result);
        }
    }
}