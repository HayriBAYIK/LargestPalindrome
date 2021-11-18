using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        public static int palindrome(int a)
        {
            int b, sum = 0, number;
            number = a;
            while (a > 0)
            {
                b = a % 10;
                sum = (sum * 10) + b;
                a = a / 10;
            }
            if (number == sum)
                return number;
            else
                return 0;

        }

        static void Main(string[] args)
        {
            /*Find the largest palindrome made from the product of two 3-digit numbers.*/
            int number = 0;
            int value = 0;
            int largestPalindrome = 0, threeDigit1 = 0, threeDigit2 = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int z = 999; z > 99; z--)
                {
                    number = i * z;
                    value = palindrome(number);
                    /*if (value != 0)
                        Console.WriteLine(value);*/
                    if (value == number && value > largestPalindrome)
                    {
                        largestPalindrome = value;
                        threeDigit1 = i;
                        threeDigit2 = z;
                    }
                }
            }
            Console.WriteLine("largest palindrome made from the product of two 3-digit numbers = " +threeDigit1+" X "+threeDigit2+" = "+ largestPalindrome);

            Console.ReadKey();

        }
    }
}