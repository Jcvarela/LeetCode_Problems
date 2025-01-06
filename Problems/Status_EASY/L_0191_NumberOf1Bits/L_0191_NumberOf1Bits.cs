// Given a positive integer n, write a function that returns the number of set bits
//  in its binary representation (also known as the Hamming weight).



namespace LeetCode_Problems.Problems.Status_EASY.L_0191_NumberOf1Bits
{
    public class L_0191_NumberOf1Bits
    {
        public static int HammingWeight(int n)
        {
            int result = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                {
                    n--;
                    result++;
                }
                n /= 2;
            }

            return result;
        }
    }
}