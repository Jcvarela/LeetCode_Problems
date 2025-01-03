public class FlatternNestedListIterator_0341
{

    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedIterator
    {

        private IList<int> myList;
        private int pos;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            pos = 0;
            myList = new List<int>();
            CleanListRecursive(myList, nestedList);
        }

        public bool HasNext()
        {
            return pos < myList.Count;
        }

        public int Next()
        {
            return myList[pos++];
        }

        private void CleanListRecursive(IList<int> myList, IList<NestedInteger> nestedList)
        {
            if (nestedList == null || nestedList.Count == 0)
            {
                return;
            }

            foreach (NestedInteger n in nestedList)
            {
                if (n.IsInteger())
                {
                    myList.Add(n.GetInteger());
                }
                else
                {
                    CleanListRecursive(myList, n.GetList());
                }
            }
        }
    }
}