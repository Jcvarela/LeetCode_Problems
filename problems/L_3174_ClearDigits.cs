using System.Text;

public class ClearDigits_3174
{
    public string ClearDigits(string s)
    {
        var result = new StringBuilder();

        var charRemoveCount = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var tempChar = s[i];
            if (tempChar >= '0' && tempChar <= '9')
            {
                charRemoveCount++;
                continue;
            }
            else if (charRemoveCount > 0)
            {
                charRemoveCount--;
                continue;
            }
            result.Insert(0, tempChar);
        }

        return result.ToString();
    }
}