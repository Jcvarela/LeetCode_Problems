
namespace LeetCode_Problems.Problems.Status_EASY.L_0069_sqrt
{
    public class L_0069_sqrt
    {
        public static int MySqrt(int x)
        {

            if (x == 0)
            {
                return 0;
            }
            if (x < 4)
            {
                return 1;
            }

            int low = 1, high = x;
            int result = 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (mid <= x / mid)
                {
                    low = mid + 1;
                    result = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }
    }
}