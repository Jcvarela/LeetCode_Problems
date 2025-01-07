using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0412_FizzBuzz
{
    public class L_0412_FizzBuzzTest
    {
        [Theory]
        [InlineData(1, new string[] { "1" })]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzz_TestCases(int n, string[] expected)
        {
            var result = L_0412_FizzBuzz.FizzBuzz(n);
            Assert.Equal(expected, result);
        }
    }
}