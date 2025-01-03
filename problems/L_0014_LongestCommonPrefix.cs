public class LongestCommonPrefix0014
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        int startResult = -1;
        int endResult = -1;

        int tempStart = -1;
        int pos = 0;
        bool isPrefix;
        bool whileLoopIsActive = true;
        while (whileLoopIsActive)
        {
            isPrefix = true;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length <= pos || strs[i - 1].Length <= pos)
                {
                    whileLoopIsActive = false;
                    isPrefix = false;
                    break;
                }

                if (strs[i][pos] != strs[i - 1][pos])
                {
                    isPrefix = false;
                    break;
                }
            }

            if (isPrefix)
            {
                if (tempStart == -1)
                {
                    tempStart = pos;
                }
            }
            else if (tempStart != -1)
            {
                if (endResult - startResult < pos - tempStart)
                {
                    startResult = tempStart;
                    endResult = pos;
                }
            }
            pos++;
        }

        if (startResult == -1)
        {
            return "";
        }

        Console.WriteLine(startResult);
        Console.WriteLine(endResult);
        return strs[0].Substring(startResult, endResult - startResult);
    }
}