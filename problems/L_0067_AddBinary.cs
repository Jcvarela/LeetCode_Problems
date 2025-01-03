using System.Text;

public class AddBinary0067
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        var result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digitA = (i >= 0) ? a[i] - '0' : 0;
            int digitB = (j >= 0) ? b[j] - '0' : 0;

            int sum = digitA + digitB + carry;
            carry = sum / 2;

            result.Append((char)((sum % 2) + '0'));

            i--;
            j--;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}