using System;


namespace Strings_Basic_Programs
{
    internal class RemoveSpecialCharecter
    {
        static void Main(string[] args)
        {
            string word = "hello@123$&(";
            string result = "";
            for(int i=0;i<word.Length-1;i++)
            {
                char ch = word[i];
                if ((ch >= 'a' && ch <= 'z') ||
                    (ch >= 'A' && ch <= 'Z') ||
                    (ch >= '0' && ch <= '9'))
                {
                    result += ch; // add only letters and numbers
                }
            }

            Console.WriteLine("Cleaned string: " + result);
        }
    }
        }
    

