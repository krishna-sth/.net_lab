using System;

class SwapNumbers
{
    public void Swap()
    {
        int num1, num2, temp;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nBefore Swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);

        // Swapping logic
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);
    }
}
