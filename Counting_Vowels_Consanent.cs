using System;


namespace Strings_Basic_Programs
{
    internal class Counting_Vowels_Consanent
    {
        static void Main(string[] args)
        {
            string str = "krishnaaaa";
            int vowel = 0;
            int consanant = 0;
            for(int i=0;i<str.Length-1;i++)
            {
                char c = char.ToLower(str[i]);
                if(c>='a'&& c<='z')
                {
                    if(c=='a'|| c=='e'|| c=='i'|| c=='o'|| c=='u')
                    {
                        vowel++;
                    }
                    else
                    {
                        consanant++;
                    }
                }
            }
            Console.WriteLine("Vowels" + vowel);
            Console.WriteLine("consanant" + consanant);

        }
    }
}
