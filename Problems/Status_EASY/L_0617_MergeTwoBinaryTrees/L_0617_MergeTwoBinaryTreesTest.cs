using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0617_MergeTwoBinaryTrees
{
    public class L_0617_MergeTwoBinaryTreesTest
    {
        [Fact]
        public void MergeTrees_BothNull_ReturnsNull()
        {
            TreeNode root1 = null;
            TreeNode root2 = null;

            TreeNode result = L_0617_MergeTwoBinaryTrees.MergeTrees(root1, root2);

            Assert.Null(result);
        }

        [Fact]
        public void MergeTrees_OneNull_ReturnsNonNull()
        {
            TreeNode root1 = new TreeNode(1);
            TreeNode root2 = null;

            TreeNode result = L_0617_MergeTwoBinaryTrees.MergeTrees(root1, root2);

            Assert.Equal(root1, result);
        }

        [Fact]
        public void MergeTrees_BothNonNull_ReturnsMergedTree()
        {
            TreeNode root1 = new TreeNode(1)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(5)
                },
                right = new TreeNode(2)
            };

            TreeNode root2 = new TreeNode(2)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(7)
                }
            };

            TreeNode expected = new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(7)
                }
            };

            TreeNode result = L_0617_MergeTwoBinaryTrees.MergeTrees(root1, root2);

            Assert.True(AreEqual(expected, result));
        }

        private bool AreEqual(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            if (node1 == null || node2 == null)
                return false;
            if (node1.val != node2.val)
                return false;

            return AreEqual(node1.left, node2.left) && AreEqual(node1.right, node2.right);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}