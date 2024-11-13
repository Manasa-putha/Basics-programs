using System;
public class armstrong
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("Enter any number");
        //int input = Convert.ToInt32(Console.ReadLine());
        //int r, temp = input, sum = 0;
        //while (input > 0)
        //{
        //    r = (input % 10);
        //    sum = sum + r * r * r;
        //    input = (input / 10);
        //}
        //Console.WriteLine(sum);
        //if (temp == sum)
        //{
        //    Console.WriteLine("armstrong number");

        //}
        //else
        //{
        //    Console.WriteLine("not");
        //}
        int input = Int32.Parse(Console.ReadLine());
        for(int i=1;i<input; i++)
        {
            if(input%i ==0)
            {
                Console.WriteLine("yes" + i);
                break;
            }
            Console.WriteLine(i);
        }

    }
}
   