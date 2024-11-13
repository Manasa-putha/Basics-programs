// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace YourNamespace
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string");
    //        string str = Console.ReadLine();
    //        string rev = "";
    //        for(int i = str.Length-1; i >= 0; i--)
    //        {
    //            rev = rev + str[i];
    //        }
    //        Console.WriteLine(rev);
    //    }
    //}
    public class Program
    {
        public static void Main(string[] args)
        {
            //string str = "Welcome To Knit";
            Console.WriteLine("Enter a string ");
            string str = Console.ReadLine(); // Your input string
            string[] words = str.Split(' '); // Split the string into words
            string result = "";

            // Reverse each word individually
            foreach (string word in words)
            {
                string rev = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    rev += word[i];
                }
                result += rev + " "; // Add the reversed word to the result
            }

            // Convert the result to uppercase
            result = result.ToUpper().Trim(); // Use Trim to remove the trailing space

            Console.WriteLine(result); // Output the final result
        }
    }
    //ARRAY REVERSE  arr={1,2,3,4} ,o/p--> {4,3,2,1}
    //public class revarr
    //{
    //    public static void Main(String[] args)
    //    {
    //        int[] array = { 1, 2, 3, 4 };
    //        int[] revrsearray = new int[array.Length];
    //        for(int i =0; i< array.Length; i++)
    //        {
    //            revrsearray[i] = array[array.Length-i-1];
    //            Console.WriteLine(revrsearray[i]);

    //        }
    //        Console.WriteLine(revrsearray);
    //        foreach(int i in revrsearray)
    //        {
    //            Console.WriteLine(i+ " ");
    //        }

    //    }
    //}

}

