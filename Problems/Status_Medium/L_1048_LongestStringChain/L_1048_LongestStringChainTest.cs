using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_1048_LongestStringChain
{
    public class L_1048_LongestStringChainTest
    {
        [Theory]
        [InlineData(new string[] { "a", "b", "ba", "bca", "bda", "bdca" }, 4)]
        [InlineData(new string[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" }, 5)]
        [InlineData(new string[] { "abcd", "dbqca" }, 1)]
        [InlineData(new string[] { "a", "ab", "ac", "bd", "abc", "abd", "abdd" }, 4)]
        [InlineData(new string[] { "a", "aa", "aaa", "aaaa" }, 4)]
        public void LongestStrChain_Test(string[] words, int expected)
        {
            int result = L_1048_LongestStringChain.LongestStrChain(words);
            Assert.Equal(expected, result);
        }
    }
}