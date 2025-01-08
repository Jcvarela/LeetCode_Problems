using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0050_powXN
{
    public class L_0050_PowXNTest
    {
        [Theory]
        [InlineData(2.0, 10, 1024.0)]
        [InlineData(2.1, 3, 9.261)]
        [InlineData(2.0, -2, 0.25)]
        [InlineData(1.0, 0, 1.0)]
        [InlineData(0.0, 5, 0.0)]
        [InlineData(-2.0, 3, -8.0)]
        [InlineData(-2.0, 2, 4.0)]
        public void MyPow_Test(double x, int n, double expected)
        {
            double result = L_0050_PowXN.MyPow(x, n);
            Assert.Equal(expected, result, 5);
        }
    }
}