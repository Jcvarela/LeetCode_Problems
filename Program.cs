using System.Xml.XPath;

namespace LeetCode_Problems;

class Program
{
    static void Main(string[] args)
    {

        // var result = LongestCommonPrefix0014.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        TreeNode root = new TreeNode(90)
        {
            left = new TreeNode(69)
            {
                left = new TreeNode(49)
                {
                    right = new TreeNode(52)
                },
                right = new TreeNode(89)
            }
        };

        MinimumDistanceBetweenBSTNode_0783 minDiffCalculator = new MinimumDistanceBetweenBSTNode_0783();
        int minDiff = minDiffCalculator.MinDiffInBST(root);
        Console.WriteLine(minDiff);
    }
}
