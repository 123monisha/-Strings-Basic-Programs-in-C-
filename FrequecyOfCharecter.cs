using System;
using System.Collections.Generic;


namespace Strings_Basic_Programs
{
    internal class FrequecyOfCharecter
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Dictionary<char, int> freq = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (freq.ContainsKey(ch))
                {
                    freq[ch] += 1;  // increment count
                }
                else
                {
                    freq[ch] = 1;   // first occurrence
                }
            }

            // Print frequencies
            foreach (var entry in freq)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    }
}