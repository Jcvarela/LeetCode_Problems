public class HappyNumver0202
{
    public bool IsHappy(int n)
    {

        int count = n;
        int temp;
        do
        {
            temp = count;
            count = 0;

            while (temp > 0)
            {
                count += temp % 10 * (temp % 10);
                temp /= 10;
            }
            if (count < 10 && count != 7 && count != 1)
            {
                return false;
            }
        } while (count != 1);

        return count == 1;
    }
}