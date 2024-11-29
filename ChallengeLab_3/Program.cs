namespace ChallengeLab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge Lab Week 3\n");

            // Test IsPalindrome method
            Console.WriteLine(IsPalindrome("racecar"));  // Should print: True
            Console.WriteLine(IsPalindrome("bear"));  // Should print: False

            // Test SumDigitsInString method
            Console.WriteLine(SumDigitsInString("1q2w3e"));  // Should print: 6
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um"));  // Should print: 9
            Console.WriteLine(SumDigitsInString(""));  // Should print: 0
        }

        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        static int SumDigitsInString(string str)
        {
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += (int)char.GetNumericValue(str[i]);
                }
            }

            return sum;
        }
    }
}
