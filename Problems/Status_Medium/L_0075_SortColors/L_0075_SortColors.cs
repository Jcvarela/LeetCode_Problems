namespace LeetCode_Problems.Problems.Status_Medium.L_0075_SortColors
{
    public class L_0075_SortColors
    {
        public static void SortColors(int[] nums)
        {
            var whiteCount = 0;
            var length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    if (whiteCount != 0)
                    {
                        nums[i - whiteCount] = 0;
                        nums[i] = 1;
                    }
                }
                else if (nums[i] == 1)
                {
                    whiteCount++;
                }
                else
                {
                    nums[i--] = nums[--length];
                    nums[length] = 2;
                }
            }
        }
    }
}