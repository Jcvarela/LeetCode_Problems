public class SelfDividedNumber_0728
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if (isSelfDivided(i))
            {
                result.Add(i);
            }
        }


        return result;
    }

    private bool isSelfDivided(int num)
    {

        var tempNum = num;
        while (tempNum > 0)
        {
            var temp = tempNum % 10;

            if (temp == 0 || num % (temp) != 0)
            {
                return false;
            }
            tempNum /= 10;
        }

        return true;
    }
}