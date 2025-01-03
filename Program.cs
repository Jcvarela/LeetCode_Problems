using System.Xml.XPath;

namespace leetCode;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine(PalindromeChecker.IsPalindrome(121));

        // ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9)));
        // ListNode l2 = new ListNode(9);
        // AddTwoNumbers02 addTwoNumbers02 = new AddTwoNumbers02();
        // var result = addTwoNumbers02.AddTwoNumbers(l1, l2);
        // while (result != null)
        // {
        //     Console.WriteLine(result.val);
        //     result = result.next;
        // }


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
