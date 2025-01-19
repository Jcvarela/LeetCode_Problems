namespace LeetCode_Problems.Problems.Status_Medium.L_1283_FindTheSmallestDivisorGivenAThreshold
{
    public class L_1283_FindTheSmallestDivisorGivenAThreshold
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {

            long sum = 0;
            int right = 0;
            foreach (int n in nums)
            {
                sum += n;
                if (n > right)
                {
                    right = n;
                }
            }

            // Divide by biggest number because the threshold is the length of nums
            if (nums.Length == threshold)
            {
                return right;
            }

            if (sum < threshold)
            {
                return 1;
            }

            int left = 1;
            int divisor = 0;
            int result = 1;

            while (left <= right)
            {
                divisor = (left + right) / 2;
                sum = 0;

                foreach (int n in nums)
                {
                    sum += (n + divisor - 1) / divisor;
                }

                if (sum > threshold)
                {
                    left = divisor + 1;
                }
                else
                {
                    right = divisor - 1;
                    result = divisor;
                }
            }

            return result;
        }
    }
}