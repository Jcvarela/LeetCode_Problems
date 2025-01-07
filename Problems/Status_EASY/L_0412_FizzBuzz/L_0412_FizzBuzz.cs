namespace LeetCode_Problems.Problems.Status_EASY.L_0412_FizzBuzz
{
    public class L_0412_FizzBuzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            var result = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = i.ToString();
                }
            }

            return result;
        }
    }
}