public class SpiralMatrix2_0059
{
    public int[][] GenerateMatrix(int n)
    {

        var result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        var dirRow = new int[] { 0, 1, 0, -1 };
        var dirCol = new int[] { 1, 0, -1, 0 };

        int dirIndex = 0;

        int row = 0;
        int col = 0;

        int length = n * n;

        for (int i = 1; i <= length; i++)
        {
            result[row][col] = i;

            int nextRow = row + dirRow[dirIndex];
            int nextCol = col + dirCol[dirIndex];

            if (nextRow >= n || nextRow < 0 || nextCol >= n || nextCol < 0 || result[nextRow][nextCol] != 0)
            {
                dirIndex = (dirIndex + 1) % 4;
                nextRow = row + dirRow[dirIndex];
                nextCol = col + dirCol[dirIndex];
            }

            row = nextRow;
            col = nextCol;
        }
        return result;
    }
}