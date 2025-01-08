using System;
using System.Collections.Generic;

namespace LeetCode_Problems.Status_EASY.L0163_MissingRanges
{
    public class MissingRanges
    {
        public static IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
        {
            if (nums.Length == 0)
            {
                return new List<IList<int>> { new List<int> { lower, upper } };
            }

            var result = new List<IList<int>>();

            if (nums[0] != lower)
            {
                result.Add(new List<int> { lower, nums[0] - 1 });
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > 1)
                {
                    result.Add(new List<int> { nums[i - 1] + 1, nums[i] - 1 });
                }
            }

            if (nums[^1] != upper)
            {
                result.Add(new List<int> { nums[^1] + 1, upper });
            }

            return result;
        }
    }
}