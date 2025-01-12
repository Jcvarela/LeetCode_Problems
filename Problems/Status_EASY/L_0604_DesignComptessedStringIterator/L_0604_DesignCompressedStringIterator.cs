namespace LeetCode_Problems.Problems.Status_EASY.L_0604_DesignCompressedStringIterator
{
    public class L_0604_DesignCompressedStringIterator
    {
        private readonly string compressedString;
        private int index;
        private int count;
        private char activeChar;
        private static readonly char EMPTY = ' ';

        public L_0604_DesignCompressedStringIterator(string compressedString)
        {
            this.compressedString = compressedString;
            index = 0;
            SetNextIndex();
        }

        public char Next()
        {
            if (!HasNext())
            {
                return EMPTY;
            }

            count--;
            var result = activeChar;
            if (count == 0)
            {
                SetNextIndex();
            }

            return result;
        }

        public bool HasNext()
        {
            return count > 0 || index < compressedString.Length;
        }

        private void SetNextIndex()
        {
            if (index >= compressedString.Length)
            {
                return;
            }

            activeChar = compressedString[index];
            index++;
            count = 0;
            while (index < compressedString.Length && char.IsDigit(compressedString[index]))
            {
                count = count * 10 + (compressedString[index] - '0');
                index++;
            }
        }
    }
}