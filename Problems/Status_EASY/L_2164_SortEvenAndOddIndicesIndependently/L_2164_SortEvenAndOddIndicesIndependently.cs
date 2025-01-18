namespace LeetCode_Problems.Problems.Status_EASY.L_2164_SortEvenAndOddIndicesIndependently
{
    public class L_2164_SortEvenAndOddIndicesIndependently
    {
        public static int[] SortEvenOdd(int[] nums)
        {
            if (nums.Length < 3)
            {
                return nums;
            }

            var length = nums.Length;
            var isOddLength = length % 2 == 1;

            var odd = new int[length / 2];
            var even = new int[(length + 1) / 2];

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = nums[i];
                }
                else
                {
                    odd[i / 2] = nums[i];
                }
            }

            Array.Sort(even, (a, b) => a - b);
            Array.Sort(odd, (a, b) => b - a);

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    nums[i] = even[i / 2];
                }
                else
                {
                    nums[i] = odd[i / 2];
                }
            }

            return nums;
        }
    }
}