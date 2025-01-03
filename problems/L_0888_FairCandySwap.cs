public class FairCandySwap_0888
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {

        int aliceCount = 0;
        for (int i = 0; i < aliceSizes.Length; i++)
        {
            aliceCount += aliceSizes[i];
        }

        int bobCount = 0;
        for (int i = 0; i < bobSizes.Length; i++)
        {
            bobCount += bobSizes[i];
        }

        HashSet<int> bobSet = new HashSet<int>(bobSizes);
        int delta = (bobCount - aliceCount) / 2;

        foreach (int a in aliceSizes)
        {
            if (bobSet.Contains(a + delta))
            {
                return [a, a + delta];
            }
        }

        return null;
    }
}