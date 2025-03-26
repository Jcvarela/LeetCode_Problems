using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0118_PascalTriangle
{
    public class L_118_PascalTriangleTest
    {
         public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 1, new int[][] { new int[] { 1 } } };
            yield return new object[] { 2, new int[][] { new int[] { 1 }, new int[] { 1, 1 } } };
            yield return new object[] { 3, new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 } } };
            yield return new object[] { 4, new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 } } };
            yield return new object[] { 5, new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 } } };
        }


        [Theory]
        [MemberData(nameof(TestData))]
        public void Generate_Test(int numRows, int[][] expected)
        {
            var result = new L_118_PascalTriangle().Generate(numRows);

            Assert.Equal(expected.Length, result.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
} 
