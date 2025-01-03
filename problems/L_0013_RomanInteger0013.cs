public class RomanToInt0013
{

    private static readonly int[] RomanValues = RomanConverter(); // 26 for all uppercase letters

    static int[] RomanConverter()
    {

        int[] tempValues = new int[26];
        tempValues['I' - 'A'] = 1;
        tempValues['V' - 'A'] = 5;
        tempValues['X' - 'A'] = 10;
        tempValues['L' - 'A'] = 50;
        tempValues['C' - 'A'] = 100;
        tempValues['D' - 'A'] = 500;
        tempValues['M' - 'A'] = 1000;

        return tempValues;
    }

    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = RomanValues[s[i] - 'A'];
            int next = (i + 1 < s.Length) ? RomanValues[s[i + 1] - 'A'] : 0;

            result += (current < next) ? -current : current;
        }

        return result;
    }
}