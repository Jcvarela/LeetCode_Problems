public class ButtonWithLongestPushTime_3386
{
    public static int ButtonWithLongestTime(int[][] events)
    {
        if (events == null || events[0] == null)
        {
            return 0;
        }

        int resultIndex = 0;
        int maxPress = events[0][1];

        for (int i = 1; i < events.Length; i++)
        {
            var tempPress = events[i][1] - events[i - 1][1];
            if (tempPress > maxPress || (tempPress == maxPress && events[i][0] < events[resultIndex][0]))
            {
                resultIndex = i;
                maxPress = tempPress;
            }
        }

        return events[resultIndex][0];
    }
}