using System;

namespace LeetCode_Problems.Status_Medium
{
    public class L_0647_PalindromicSubstring
    {
        int count = 0;
        public int CountSubstrings(string s)
        {

            if (s.Length <= 1)
            {
                return s.Length;
            }

            for (int i = 0; i < s.Length; i++)
            {
                ExpandAroundCenterPalindrom(i, i, s);
                ExpandAroundCenterPalindrom(i, i + 1, s);
            }

            return count;
        }

        public void ExpandAroundCenterPalindrom(int left, int right, string s)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
        }

    }
}