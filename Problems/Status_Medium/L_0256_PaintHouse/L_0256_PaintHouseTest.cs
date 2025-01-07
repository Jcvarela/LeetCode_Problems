using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0256_PaintHouse
{
    public class L_0256_PaintHouseTest
    {

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { new int[][] { new int[] { 17, 2, 17 }, new int[] { 16, 16, 5 }, new int[] { 14, 3, 19 } }, 10 };
            yield return new object[] { new int[][] { new int[] { 7, 6, 2 } }, 2 };
            yield return new object[] { new int[][] { new int[] { 1, 5, 3 }, new int[] { 2, 9, 4 } }, 5 };
            yield return new object[] { new int[][] { new int[] { 8, 16, 12 }, new int[] { 14, 3, 19 }, new int[] { 17, 2, 17 } }, 28 };
            yield return new object[] { new int[][] { new int[] { 3, 5, 3 }, new int[] { 6, 17, 6 }, new int[] { 7, 13, 18 }, new int[] { 9, 10, 18 } }, 26 };
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void MinCost_Test(int[][] costs, int expected)
        {
            int result = L_0256_PaintHouse.MinCost(costs);
            Assert.Equal(expected, result);
        }
    }
}