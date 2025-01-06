using Xunit;

namespace LeetCode_Problems.Problems.Status_Medium.L_0208_ImplementTrie_Prefix_Tree
{
    public class L_0208_ImplementTrie_Prefix_TreeTest
    {
        [Fact]
        public void Insert_Search_Test()
        {
            var trie = new L_0208_ImplementTrie_Prefix_Tree();
            trie.Insert("apple");
            Assert.True(trie.Search("apple"));   // returns true
            Assert.False(trie.Search("app"));    // returns false
            trie.Insert("app");
            Assert.True(trie.Search("app"));     // returns true
        }

        [Fact]
        public void StartsWith_Test()
        {
            var trie = new L_0208_ImplementTrie_Prefix_Tree();
            trie.Insert("apple");
            Assert.True(trie.StartsWith("app")); // returns true
            Assert.False(trie.StartsWith("apl")); // returns false
        }

        [Fact]
        public void Insert_MultipleWords_Test()
        {
            var trie = new L_0208_ImplementTrie_Prefix_Tree();
            trie.Insert("apple");
            trie.Insert("app");
            trie.Insert("apricot");
            Assert.True(trie.Search("apple"));   // returns true
            Assert.True(trie.Search("app"));     // returns true
            Assert.True(trie.Search("apricot")); // returns true
            Assert.False(trie.Search("banana")); // returns false
        }

        [Fact]
        public void StartsWith_MultiplePrefixes_Test()
        {
            var trie = new L_0208_ImplementTrie_Prefix_Tree();
            trie.Insert("apple");
            trie.Insert("app");
            trie.Insert("apricot");
            Assert.True(trie.StartsWith("ap"));  // returns true
            Assert.True(trie.StartsWith("app")); // returns true
            Assert.True(trie.StartsWith("apr")); // returns true
            Assert.False(trie.StartsWith("ban")); // returns false
        }
    }
}