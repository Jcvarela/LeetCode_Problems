namespace LeetCode_Problems.Problems.Status_Medium.L_0208_ImplementTrie_Prefix_Tree
{
    public class L_0208_ImplementTrie_Prefix_Tree
    {
        List<string> words;

        public L_0208_ImplementTrie_Prefix_Tree()
        {
            words = new List<string>();
        }

        public void Insert(string word)
        {
            int index = words.BinarySearch(word);
            if (index < 0)
            {
                index = ~index;
            }
            words.Insert(index, word);
        }

        public bool Search(string word)
        {
            int index = words.BinarySearch(word);
            return index >= 0;
        }

        public bool StartsWith(string prefix)
        {
            if (words.Count == 0)
            {
                return false;
            }

            int index = words.BinarySearch(prefix);
            if (index < 0)
            {
                index = ~index;
            }

            if (index == words.Count)
            {
                return false;
            }

            return words[index].StartsWith(prefix);
        }
    }
}