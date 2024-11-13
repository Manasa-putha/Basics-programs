using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Basic_Programs.factorial;

namespace Basic_Programs
{
    public class factorial
    {
        //    public class fact(int i) { 
        //    {
        //       for (i = 1; i <= a; i++)
        //        {
        //            Fact = Fact* i;
        //        }
        //    Console.WriteLine("factorial of a num is "+Fact);

        //    }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number");
        //    int a = int.Parse(Console.ReadLine());
        //    //int  f = 5;
        //    int i, Fact = 1;
        //    int result = fact(a);


        //}
        public static int fact(int a )
        {
            int i, n = 1;
            for (i = 1; i <= a; i++)
            {
                n = i * n;
            }
            return n;
        }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number");
        //    int a = int.Parse(Console.ReadLine());
        //    int res = fact(a);
        //    Console.WriteLine("factorial of  a number is " + res);
        //    Console.WriteLine("Enter a number");
            
        //}
    }
}

