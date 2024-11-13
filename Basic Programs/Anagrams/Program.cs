// See https://aka.ms/new-console-template for more information
using System;
namespace anagrams
{
    public class anagrams
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st string");
            string str1 = Console.ReadLine(),rev=" ",emp=" ";
            Console.WriteLine("Enter the 2nd string");
            string str2 = Console.ReadLine();
            char[] cleanedstr1 = new char[str1.Length];
            char[] cleanedstr2 = new char[str2.Length];
            int index1=0,index2=0;

            foreach(char c in str1)
            {
                if (c != ' ')
                {
                    cleanedstr1[index1++] = char.ToLower(c);
                }
            }
            foreach(char c in str2)
            {
                if(c !=' ')
                {
                    cleanedstr2[index2++] = char.ToLower(c);
                }
            }
            //Array.Resize(ref cleanedstr1, index1);
            //Array.Resize(ref cleanedstr2, index2);
            Array.Sort(cleanedstr1);
            Array.Sort(cleanedstr2);
            if(new string(cleanedstr1) == new string(cleanedstr2))
            {
                Console.WriteLine("The strings are anagrams");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
            //for(int i = 0; i < str.Length; i++)
            //{
            //    for(int j=str.Length-1;j>= 0; j--)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            rev = rev + str[i];
            //        }

            //    }
            //    if (str[i] == rev[i])
            //    {
            //        int count = 1;
            //    }
            //}

            // Console.WriteLine(count );
        }
    }
}