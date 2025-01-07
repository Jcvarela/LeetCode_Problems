namespace LeetCode_Problems.Problems.Status_Medium.L_1048_LongestStringChain
{
    public class L_1048_LongestStringChain
    {
        public static int LongestStrChain(string[] words)
        {
            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));


            var mapCount = new Dictionary<string, int>();
            int maxCount = 0;
            foreach (string word in words)
            {

                int count = 1;

                for (int i = 0; i < word.Length; i++)
                {

                    var tempWord = word.Substring(0, i) + word.Substring(i + 1);

                    if (mapCount.ContainsKey(tempWord))
                    {
                        count = Math.Max(count, mapCount[tempWord] + 1);
                    }


                }

                mapCount[word] = count;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }
    }
}