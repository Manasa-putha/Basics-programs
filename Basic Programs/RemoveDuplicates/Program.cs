using System;

namespace RemoveDuplicates
{
    public class Removeduplicates
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a string");
          //  string revv = "programming";
            string str = Console.ReadLine();
            string rev=" ",emp="";
            for(int i =0; i < str.Length; i++)
            {
                int j;
                for( j = 0; j < i; j++)
                {
                    if (str[i]== str[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    rev = rev + str[i];
                }
            }
            Console.WriteLine("Removed Duplicates in a string {0}",rev);
      
        }
    }
}
