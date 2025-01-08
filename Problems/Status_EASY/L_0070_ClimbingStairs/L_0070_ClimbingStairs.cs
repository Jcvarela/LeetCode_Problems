namespace LeetCode_Problems.Problems.Status_EASY.L_0070_ClimbingStairs
{
    public class L_0070_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {

            if (n == 1) return 1;
            if (n == 2) return 2;

            int prev = 1;
            int result = 2;


            for (int i = 2; i < n; i++)
            {
                result += prev;
                prev = result - prev;
            }

            return result;
        }
    }
}