public class MinimumDistanceBetweenBSTNode_0783
{
    public int MinDiffInBST(TreeNode root)
    {
        // return GetMinDiffRecursive(root, -1000000, 1000000);
        int minDiff = int.MaxValue;
        int? prev = null;

        void InOrderTraversal(TreeNode node)
        {
            if (node == null) return;

            // Traverse the left subtree
            InOrderTraversal(node.left);

            // Process the current node
            if (prev.HasValue)
            {
                minDiff = Math.Min(minDiff, node.val - prev.Value);
            }
            prev = node.val;

            // Traverse the right subtree
            InOrderTraversal(node.right);
        }

        InOrderTraversal(root);
        return minDiff;
    }

    public int GetMinDiffRecursive(TreeNode root, int leftClosesValue, int rightClosesValue)
    {
        if (root == null)
        {
            return int.MaxValue;
        }

        var minValue = int.MaxValue;
        if (root.left != null)
        {
            if (root.val - root.left.val < minValue)
            {
                minValue = root.val - root.left.val;
            }

            if (root.left.val - leftClosesValue < minValue)
            {
                minValue = root.left.val - leftClosesValue;
            }

            int temp = GetMinDiffRecursive(root.left, leftClosesValue, root.val);
            if (temp < minValue)
            {
                minValue = temp;
            }
        }

        if (root.right != null)
        {
            if (root.right.val - root.val < minValue)
            {
                minValue = root.right.val - root.val;
            }

            if (rightClosesValue - root.right.val < minValue)
            {
                minValue = rightClosesValue - root.right.val;
            }

            int temp = GetMinDiffRecursive(root.right, root.val, rightClosesValue);
            if (temp < minValue)
            {
                minValue = temp;
            }
        }

        return minValue;
    }
}