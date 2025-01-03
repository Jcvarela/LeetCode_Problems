public class PathSum0112
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        return FindSum(root, root.val, targetSum);
    }

    public bool FindSum(TreeNode node, int count, int target)
    {

        if (node.left == null && node.right == null)
        {
            return count == target;
        }


        if (node.left != null)
        {
            if (FindSum(node.left, count + node.left.val, target))
            {
                return true;
            }
        }

        if (node.right != null)
        {
            if (FindSum(node.right, count + node.right.val, target))
            {
                return true;
            }
        }

        return false;
    }
}