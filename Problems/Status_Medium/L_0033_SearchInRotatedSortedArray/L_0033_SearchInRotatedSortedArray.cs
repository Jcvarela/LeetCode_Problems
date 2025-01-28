namespace LeetCode_Problems.Problems.Status_Medium.L_0033_SearchInRotatedSortedArray
{
    public class L_0033_SearchInRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {

            int start = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    start = i;
                    break;
                }
            }

            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int nextMid = (mid + start) % nums.Length;

                if (nums[nextMid] == target)
                {
                    return nextMid;
                }

                if (target > nums[nextMid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}