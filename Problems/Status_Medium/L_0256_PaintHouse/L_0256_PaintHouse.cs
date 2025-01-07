namespace LeetCode_Problems.Problems.Status_Medium.L_0256_PaintHouse
{
    public class L_0256_PaintHouse
    {
        public static int MinCost(int[][] costs)
        {

            int length = costs.Length;

            int prevRed = 0, prevBlue = 0, prevGreen = 0;

            for (int i = 0; i < length; i++)
            {

                int currRed = costs[i][0] + Math.Min(prevBlue, prevGreen);
                int currBlue = costs[i][1] + Math.Min(prevRed, prevGreen);
                int currGreen = costs[i][2] + Math.Min(prevRed, prevBlue);

                prevRed = currRed;
                prevBlue = currBlue;
                prevGreen = currGreen;
            }

            return Math.Min(prevGreen, Math.Min(prevRed, prevBlue));
        }
    }
}