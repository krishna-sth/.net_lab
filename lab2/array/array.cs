using System;

class ArraySum
{
    public void CalculateSum()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element " + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("\nThe sum of array elements is: " + sum);
    }
}
