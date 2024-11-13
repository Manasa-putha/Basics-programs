/// <summary>
/// This is Bubble sort 
/// </summary>
//public class search
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 11, 7, 3, 5, 6, 1, 2, 0, 8, 4, 9 };
//        Console.WriteLine("");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            for (int j = 0; j < arr.Length - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    int temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                }
//            }
//        }
//        //Console.WriteLine(arr);
//        foreach (int item in arr)
//        {
//            // int[] array= new int[item];
//            int i = item;
//            Console.WriteLine(item);
//        }

//    }
//}

using System;

public class BinarySearchExample
{
    public static void Main(string[] args)
    {
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
        int target = 7;

        int result = BinarySearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("Element found at index: " + result);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    public static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                return mid; // Target found
            }
            else if (arr[mid] < target)
            {
                low = mid + 1; // Search in the right half
            }
            else
            {
                high = mid - 1; // Search in the left half
            }
        }

        return -1; // Target not found
    }
}
