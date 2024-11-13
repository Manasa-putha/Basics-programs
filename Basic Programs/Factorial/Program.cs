using System;
public class fact
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int input = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for(int i =1;i <= input; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine(" factorial of number is :"+fact );
    }
}