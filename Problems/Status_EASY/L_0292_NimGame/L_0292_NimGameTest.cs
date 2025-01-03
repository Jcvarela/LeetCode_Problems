
using Xunit;

namespace leetCode.Problems.Status_EASY.L_0292_NimGame
{
    public class L_0292_NimGameTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, true)]
        [InlineData(10, true)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        public void CanWinNim_TestCases(int n, bool expected)
        {
            bool result = L_0292_NimGame.CanWinNim(n);
            Assert.Equal(expected, result);
        }
    }
}

