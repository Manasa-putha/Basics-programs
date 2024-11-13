// See https://aka.ms/new-console-template for more information


Console.WriteLine("enter  a string");
string str = Console.ReadLine(),rev="";
for (int i = str.Length - 1; i >= 0; i--)
{
    rev = rev + str[i];
}
if (str == rev)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}