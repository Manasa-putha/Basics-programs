using System;
public class palin
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a digit");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = 0, r;
       while (input >0)
        {
            r = input % 10;
            sum = (sum * 10 + r);
            input = input / 10;
        }
        Console.WriteLine(sum);
        Console.WriteLine("palindrome");
    }
}