using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
   
    public class fibonacci
    {
        //public static void Main(string[] args)
        //{
        //    int count = 10;
        //    int a = 0, b = 1, c;
        //    Console.WriteLine($"{a} {b} ");
        //    for(int i= 2; i < count; i++)
        //    {
        //        c = a + b;
        //        Console.WriteLine($" {c}");
        //        a = b;
        //        b = c;

        //    }
        //}
    }
   public class Plaindrome
    {
        //public static void Main(string[] args)
        //{
        //    //Console.WriteLine("enter a string");
        //    //    string s = (Console.ReadLine());
        //    //    for(int i = 0; i < s.Length; i++)
        //    //    {

        //    //    }
        //    int pal = int.Parse(Console.ReadLine()),c;
        //    for(int i = 1; i<=pal; i++)
        //    {
        //        //if (i % pal == 0 && i % 1 == 0)
        //        //{
        //        //    c = 2;  
        //        //}
        //        //else
        //        //{
        //        //    Console.WriteLine("not ");
        //        //}

        //    }
        //    Console.WriteLine($"{c} prime number");


        //}

    }

    public class fib
    {
        public static void Main(string[] args)
        {
            int[] arr = { 11, 7, 3, 5, 6, 1, 2, 0, 8, 4, 9 };
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //Console.WriteLine(arr);
            foreach (int item in arr)
            {
                // int[] array= new int[item];
                int i = item;
                Console.WriteLine(item);
            }
            
        }

        //public static void Main(string[] args)
        //{
        //    //string s = "madam",rev="";
        //    //for(int c = s.Length; c>0; c--)
        //    //{
        //    //    rev = rev+"*";
        //    //    Console.WriteLine(rev);
        //    //}
        //    //Console.WriteLine(rev);
        //    string s = "madam", rev = "";
        //    for (int c = s.Length -1; c >= 0; c--)
        //    {
        //        rev = rev + s[c];
        //        //Console.WriteLine(rev);
        //    }
        //    Console.WriteLine(rev);
        //    if (s == rev)
        //    {
        //        Console.WriteLine("is plaindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not a palindromr");
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    string str = "ababa",n=" ";
        //    int cout;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (i == 0 || (str[i] != str[i - 1]))
        //        {
        //            n = n + str[i];
        //            //Console.WriteLine(n);
        //        }

        //    }
        //    Console.WriteLine(n);
        //    if (str == n)
        //    {
        //        Console.WriteLine("equal");
        //    }
        //}
    }
}
