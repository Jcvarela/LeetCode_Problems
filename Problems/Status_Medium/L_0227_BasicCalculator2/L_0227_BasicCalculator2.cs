namespace LeetCode_Problems.Problems.Status_Medium.L_0227_BasicCalculator2
{
    public class L_0227_BasicCalculator2
    {
        public static int Calculate(string s)
        {
            int result = 0;
            int currentNum = 0;
            int lastNum = 0;
            int operatorValue = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];


                if (char.IsDigit(a))
                {
                    currentNum = currentNum * 10 + (a - '0');
                }

                if ((!char.IsDigit(a) && a != ' ') || i == s.Length - 1)
                {
                    if (operatorValue == 0)
                    { // Addition
                        result += lastNum;
                        lastNum = currentNum;
                    }
                    else if (operatorValue == 1)
                    { // Subtraction
                        result += lastNum;
                        lastNum = -currentNum;
                    }
                    else if (operatorValue == 2)
                    { // Multiplication
                        lastNum = lastNum * currentNum;
                    }
                    else if (operatorValue == 3)
                    { // Division
                        lastNum = lastNum / currentNum;
                    }

                    if (a == '+') operatorValue = 0;
                    if (a == '-') operatorValue = 1;
                    if (a == '*') operatorValue = 2;
                    if (a == '/') operatorValue = 3;

                    currentNum = 0;
                }
            }

            result += lastNum;

            return result;
        }
    }
}