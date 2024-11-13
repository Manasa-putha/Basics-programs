public class fibnoaci
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a count for fibonacci series");
        int i =Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, cout;
        Console.WriteLine(a);
        Console.WriteLine( b);
        for(int j = 2; j < i; j++)
        {
            cout = a + b;
            Console.WriteLine(cout);
            a = b;
            b = cout;
        }
    }
}