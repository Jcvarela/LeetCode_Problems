public class SecondMinimumNodeInABinaryTree_0671
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        if (root == null || (root.left == null && root.right == null))
            return -1;

        int first = root.val;
        int second = -1;


        GoThroughTree(root, ref first, ref second);

        return second;
    }

    public void GoThroughTree(TreeNode node, ref int first, ref int second)
    {
        if (node == null)
            return;

        int val = node.val;


        if (second == -1 && first != val && second != val)
        {
            if (first > val)
            {
                second = first;
                first = val;
            }
            else
            {
                second = val;
            }
        }

        GoThroughTree(node.left, ref first, ref second);
        GoThroughTree(node.right, ref first, ref second);
    }
}