using System;

namespace Strings_Basic_Programs
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            string str = "madam";
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];  // Add character at index i
            }

            if (str == rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
}
