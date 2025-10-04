using System;
namespace Strings_Basic_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "helloooooooo";
            string reverse = "";
            for(int i=word.Length-1;i>=0;i--)
            {
                reverse += word[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
