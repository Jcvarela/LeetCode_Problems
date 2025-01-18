using Xunit;

namespace LeetCode_Problems.Status_Medium
{
    public class L_0647_PalindromicSubstringTest
    {
        [Theory]
        [InlineData("abc", 3)]
        [InlineData("aaa", 6)]
        [InlineData("racecar", 10)]
        [InlineData("a", 1)]
        [InlineData("abccba", 9)]
        [InlineData("", 0)]
        public void TestCountSubstrings(string input, int expected)
        {
            var solution = new L_0647_PalindromicSubstring();
            var result = solution.CountSubstrings(input);
            Assert.Equal(expected, result);
        }
    }
}