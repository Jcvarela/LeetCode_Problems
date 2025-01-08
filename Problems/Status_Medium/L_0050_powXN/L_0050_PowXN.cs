namespace LeetCode_Problems.Problems.Status_Medium.L_0050_powXN
{
    public class L_0050_PowXN
    {
        public static double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long power = n;
            if (power < 0)
            {
                x = 1 / x;
                power = -power;
            }

            double result = 1.0;
            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    result *= x;
                }
                x *= x; // Square the base
                power /= 2;
            }

            return result;
        }
    }
}