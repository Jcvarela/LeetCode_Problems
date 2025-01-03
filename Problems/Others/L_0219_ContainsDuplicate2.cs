public class ContainsDuplicate0219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {

        if (nums.Length <= 1)
        {
            return false;
        }

        var posMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // if (posMap.ContainsKey(nums[i]))
            // {
            //     if (i - posMap[nums[i]] <= k)
            //     {
            //         return true;
            //     }
            //     else
            //     {
            //         posMap[nums[i]] = i;
            //     }
            // }
            // else
            // {
            //     posMap.Add(nums[i], i);
            // }
            if (posMap.TryGetValue(nums[i], out int prevIndex) && i - prevIndex <= k)
            {
                return true;
            }

            posMap[nums[i]] = i;
        }

        return false;
    }
}