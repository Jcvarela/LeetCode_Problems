public class SetMismatch_0645
{
    public int[]? FindErrorNums(int[] nums)
    {
        var intMap = new int[nums.Length];

        var repeated = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];

            if (intMap[value - 1] == 0)
            {
                intMap[value - 1] = i + 1;
            }
            else
            {
                repeated = value;
            }
        }

        for (int i = 0; i < intMap.Length; i++)
        {
            if (intMap[i] == 0)
            {
                return [repeated, i + 1];
            }
        }

        return null;
    }
}