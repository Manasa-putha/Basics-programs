using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
//public class Secondlargest
//{
//    static void Main(string[] args)
//    {
//        //let us define array and vars
//        var arr = new int[] { 100, -3, 95, 100, 95, 177, -5, -4, 177, 101 };

//        int biggest = 0, secondBiggest = 0;
//        for (int i = 0; i < arr.Length; ++i)
//        {
//            int arrItem = arr[i];
//            if (arrItem > biggest)
//            {
//                secondBiggest = biggest; //always store the prev value of biggest 
//                                         //to second biggest...
//                biggest = arrItem;
//            }
//            else if (arrItem > secondBiggest && arrItem < biggest) //if in our 
//                                                                   //iteration we will find a number that is bigger than secondBiggest and smaller than biggest 
//                secondBiggest = arrItem;
//        }

//        Console.WriteLine($"Biggest Number:{biggest}, SecondBiggestNumber: {secondBiggest}");
//        Console.ReadLine(); //make program wait
//    }
//}

//public class fizzBuzz
//{
//    public static void Main(string[] args)
//    {
//        int count = 100;
//        for (int i = 1; i <= count; i++)
//        {

//            if( (i%3==0) && (i%5==0)){
//                Console.WriteLine("fizz Buzz");
//                continue;
//            }
//            else if (i % 3 == 0)
//            {
//                Console.WriteLine("fizz");
//                continue;
//            }
//            else if (i % 5 == 0)
//            {
//                Console.WriteLine("buzz");
//                continue;
//            }
//            Console.WriteLine(i);
//        }
//    }

//}

//public class duplicates
//{
//    public static void Main(string[] args)
//    {
//        int[] list = { 1, 2, 3, 4, 1, 2 ,3};
//        List<int> num = new List<int>();

//        for (int i = 0; i < list.Length-1; i++)
//        {
//           for(int j = i+1;j<list.Length; j++)
//            {
//                if (list[i] == list[j])
//                {
//                     num.Add(i);


//                }
//            }

//        }
//        Console.WriteLine(num.ToString());

//    }

//}

//public class sort
//{
//    public static void Main(string[] args)
//    {
//        int[] array1 = { 1, 2, 3, 4, 5 };
//        int[] array2 = { 6, 5, 7, 8, 9, 0 };
//        int[] array3 = new int[array1.Length+array2.Length];
//        int i = 0;
//        foreach(int item in array1)
//        {
//            array3[i]= item;
//            i++;
//        }
//        foreach(int item in array2)
//        {
//            array3[i]= item;
//            i++;
//        }
//        foreach(int item in array3)
//        {
//            Console.WriteLine(item);
//        }

//    }
//}

//public class missing
//{
//    public static void Main(string[] args)
//    {
//        int a = 0,count = 0;
//        int[] array = { 3, 0, 1 };
//        for (int i = 0; i < array.Length-1; i++)
//        {

//            if (array[i] > array[i+1])
//            {
//                a = array[i];

//            }

//        }
//        for(int j=a;j>=0; j--)
//        {

//            for(int i = 0; i < array.Length; i++)
//            {
//                if (a == array[i])
//                {
//                    count++;
//                }
//            }
//            if(count == 0)
//            {
//                Console.WriteLine(a);
//                break;
//            }
//            a = a - 1;
//            count = 0;
//        }
//      // Console.WriteLine(a);
//    }
//}
//---------------------------------------------------------------
//----------------------------------------------------------
//============Collections=========
// 2 different types of collections are there 1 is genric collections and another one is non-genric collections/

//Generic collections is going to be a collection that is capable of storing specified types of values
/// <summary>
/// List<int> li = new List<int>(); -->type safe
/// Non-genric-collections --> ArrayList(any type of list),Hash Table,
/// </summary>
//class Program
//{
//static void Main(string[] args)
//{
//    //int[] arr = new int[10];
//    //Array.Resize(ref arr, 15);
//    // Console.WriteLine(arr.Length);

//    ArrayList al = new ArrayList(10);
//    Console.WriteLine(al.Capacity);
//    al.Add(100);
//    Console.WriteLine(al.Capacity);
//    al.Add(200);
//    Console.WriteLine(al.Capacity);
//    foreach(object obj in al)

//        Console.WriteLine(obj +" ");
//    al.Insert(1, 350);
//    al.Remove(200);
//    al.RemoveAt(1);
//    foreach (object obj in al)
//        Console.WriteLine(obj +" ");
//    //  Console.ReadLine();

//}
//-------------------------------------------------------------------------------------
//static void Main(string[] args) {
//    Hashtable ht = new Hashtable();
//    ht.Add("Eid",1010);
//    ht.Add("Enaeme","Scott");
//    ht.Add("Job","Manger");
//    ht.Add("salary",2500.00);
//    ht.Add("Phone","23746666");
//    ht.Add("Dname","Sales");

//    Console.WriteLine(ht["Eid"]);
//    foreach(object key in ht.Keys)
//    {
//        Console.WriteLine(key + ":" + ht[key]);
//    }

//}
//----------------------------------------------------------------------------------------

//public class GenericList
//{
//    static void Main(string[] args)
//    {
//        List<int> li = new List<int>();
//        li.Add(10); ;li.Add(20);li.Add(30);
//        // li.Add(10.5);
//        li.Insert(2, 30);
//        li.RemoveAt(3);
//       for(int i = 0; i < li.Count; i++)
//        {
//            Console.Write(li[i]+"");
//            Console.WriteLine();
//        }
//       foreach(int i in li)
//        {
//            Console.Write(i+" ");
//        }
//    }
//}
//}


//class remove_vowels
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a string");
//        string str =Console.ReadLine(),rev="",rem="";
//        for(int i = 0; i < str.Length; i++)
//        {
//            str = str.ToLower();

//            if( (str[i] == 'a') || (str[i] =='e') || (str[i] =='i') || (str[i] =='o')|| (str[i] == 'u'))
//            {
//                //rev = rev + str[i];
//                continue;
//            }
//            else
//            {
//                rem = rem + str[i];
//            }

//        }
//        Console.WriteLine(rev + " contaning vowels");
//        Console.WriteLine(rem + " contaning vowels");
//        Console.ReadLine();
//    }
//}
//class maximum_product
//{
//public static void Main(string[] args)
//{

//    int[] array = { 9,5, 6, 2, 8, 9,9,7};
//    int[] array2 = new int[array.Length-1];
//    int max =0,sum=0;

//    int maxi = 0;
//    for (int i =0; i < array.Length-1; i++)
//    {
//        array2[i] = array[i] * array[i+1];

//        // Console.WriteLine(array2[i]);
//        for (int j = 1; j < array2.Length; j++)
//        {
//            if (maxi < array2[j])
//            {
//                maxi = array2[j];
//                //Console.WriteLine(maxi);
//            }

//        }

//    }
//    Console.WriteLine(maxi);
//30,12,16,72,81
//int maxi = array2[0];
//for (int j=1; j < array2.Length; j++)
//{

//    if(maxi < array2[j])
//    {
//        maxi= array2[j];
//        //Console.WriteLine(maxi);
//    }

//}


//}
//public class missing
//{
//    public static void Main(string[] args)
//    {
//        int[] array1 = { 1, 2, 5, 3, 6, 2, 3 };
//        int max = array1[0];
//        int c = 0;
//        for (int i = 0; i < array1.Length; i++)
//        {
//            if (max < array1[i])
//            {
//                max = array1[i];
//                // Console.WriteLine(max);
//            }

//        }
//        //  Console.WriteLine(max);
//        //6

//        for (int k = 1; k <= max; k++)
//        {
//            bool found = false;
//            for (int j = 0; j < array1.Length; j++)
//            {
//                if (array1[j] == k)
//                {
//                    found = true;
//                    break;
//                }

//            }

//             if (!found)
//            {
//                Console.WriteLine(k);
//            }

//        }
//    }
//}

//public class indexReturingTarget
//{
//    public static void Main(string[] args)
//    {
//        int[] array = { 2, 1, 7, 8, 3,1 };
//        int target = 8;
//        int c = 0;
//        for(int i=0; i<array.Length-1; i++)
//        {
//            for (int j=1; j<array.Length; j++)
//            {
//                c = array[i] + array[j];
//               // Console.WriteLine(c);
//                if (c == target)
//                {
//                    Console.WriteLine(i +" "+  j);
//                   // Console.WriteLine(array[j]);
//                }
//            }

//        }


//    }
//}

//public class reverse
//{
//    public static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5 };
//        int[] array2 = {array.Length};
//        int k = 0;
//        //int[] array1 = new int[array.Length];
//        for(int i=array.Length-1; i>=0; i--)
//        {
//           for(int j=0;j<array2.Length; j++)
//            {
//                array2[j] = array[i];
//                //= temp;
//              //  array2[j] = temp;
//                Console.WriteLine(array2[j]);
//            }
//            Console.WriteLine(array2);


//        }

//    }
//}

//public class longest_substring
//{
//    public static void Main(string[] args)
//    {
//        string l = "abcbcacbb",rev="";
//        for(int i=0; i<l.Length; i++)
//        {
//          for(int j =0; j<l.Length; j++)
//            {
//                rev= rev + l[j];
//                if (rev[j] != rev[j + 1])
//                {
//                    int c=1;
//                    Console.WriteLine(c);
//                }
//                Console.WriteLine(rev );
//            }
//        }
//    }
//}

//public class remove
//{
//    public static void Main(string[] args)
//    {
//        string s = "Programming", rev = " ";
//        s = s.ToLower();
//        for (int i = 0; i < s.Length; i++)
//        {
//            bool found = false;
//            for (int j = 0; j < i; j++)
//            {

//                if (s[i] == s[j])
//                {
//                    found = true;
//                    break;

//                }

//            }
//            if (!found)
//            {
//                rev = rev + s[i];


//            }
//        }
//        Console.WriteLine(rev);
//    }
//}

//public class progrma
//{
//    public static void Main(string[] args)
//    {
//        string name = "aswiss",rev=" ";
//        int i = 0;
//        while (i < name.Length)
//        {
//            int j = 1;
//            if (name[i] != name[j])
//            {
//                Console.WriteLine(name[i]);
//                break;
//            }
//            i++;

//            j++;


//        }


//    }
//}
//public class program
//{
//    public static void Main(String[] args)
//    {
//        string s = Console.ReadLine();
//        string[] name = s.Split(' ');
//        string n = "";

//        foreach(var i in name)
//        {
//            n = n + i[0];
//            Console.WriteLine(n);
//        }
//    }

//}


//Input:
//N = 4
//arr[] = { 1, 5, 3, 2 }
//Output: 2
//Explanation: There are 2 triplets:
//1 + 2 = 3 and 3 +2 = 5

//public class Program {
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 5, 3, 2 };
//        int sum=0,count=0;
//        for(int i=0; i<arr.Length; i++)
//        {

//            for (int j = 1; j < arr.Length; j++)
//            {
//                sum = arr[i] + arr[j];

//              //  Console.WriteLine(sum);
//                for(int k=0;k<arr.Length; k++)
//                {
//                    if(sum == arr[k])
//                    {

//                       // Console.WriteLine(arr[k]);
//                        count++;
//                        break;
//                    }

//                }


//            }


//        }
//    }
//}


// Input: arr[] = [1,2,3,7,5], n = 5, s = 12 --> Output: 2 4  --> Explanation: The sum of elements from 2nd to 4th position is 12.

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int[] temp = { 1, 2, 3, 7, 5 };
//        for (int i = 0; i < temp.Length; i++)
//        {
//            for (int j = 0; j < temp.Length-1; j++)
//            {
//                if ((temp[j] + temp[j+1]) == 12) 
//                {
//                    Console.WriteLine(j);
//                    Console.WriteLine(j + 1);

//                }
//            }

//        }
//    }
//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 5 };
//        int n = 5, s = 0;
//     for(int i = 1; i < n; i++)
//        {
//            bool find = false;
//            for(int j=0;j<arr.Length; j++)
//            {
//                if (arr[j] == i )
//                {
//                    find = true;
//                }
//            }
//            if (!find)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }

// }//Input: n = 5, arr[] = [1, 2, 3, 5]Output: 4Explanation: All the numbers from 1 to 5 are present except 4.

//Input: arr[] = [1, 2, 3, -2, 5]
//Output: 9
//Explanation: Max subarray sum is 9 of elements(1, 2, 3, -2, 5) which is a contiguous subarray.

public class sumarray
{
    public static void Main(string[] args)
    {
        int[] arr = { -1, -2, -3, -4 };
        int sum = 0;
        for(int i =0; i < arr.Length; i++)
        {
            sum = sum + ( arr[i]);
           // Console.WriteLine(sum);
        }
        Console.WriteLine(sum);
    }
}