using System;

namespace Strings_Basic_Programs
{
    internal class Anagram_Check
    {
        static void Main(string[] args)
        {
            string s1= "madam";
            string s2 = "maadm";
            if(s1.Length!=s2.Length)
            {
                Console.WriteLine("its not a anagram");
            }
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string s3 = new string(c1);
            string s4 = new string(c2);

            if(s3==s4)
            {
                Console.WriteLine("it is anangram");
            }
            else
            {
                Console.WriteLine("not a anagram");
            }
        }
    }
}
