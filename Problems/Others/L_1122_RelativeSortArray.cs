public class RelativeSortArray_1122
{
    const int SMALL_OUT_OF_RANGE_NUMBER = -1000000;
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var values = new int[1001];

        for (int i = 0; i < arr2.Length; i++)
        {
            values[arr2[i]] = SMALL_OUT_OF_RANGE_NUMBER + i;
        }

        Array.Sort(arr1, (a, b) =>
        {
            if (values[a] != 0)
                a = values[a];
            if (values[b] != 0)
                b = values[b];
            return a - b;
        });
        return arr1;
    }
}