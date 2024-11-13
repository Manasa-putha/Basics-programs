using System.Diagnostics.Contracts;

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] == nums[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                result = result + nums[i];
            }
            
        }
        return result;
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Solution solution = new Solution();
        //  int[] array = { 1, 2, 1, 3, 4, 1 };
        //int[] array = new int[10];
        //array =(Console.ReadLine());
       int sum = solution.SumOfUnique(array);
        Console.WriteLine(sum);

    }

}