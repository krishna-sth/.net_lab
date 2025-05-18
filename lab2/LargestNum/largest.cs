

class largest_num
{
    public void largest()
    {
        // Input three numbers
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Find the largest number
        int largest;

        if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        // Output the result
        Console.WriteLine("The largest number is: " + largest);
    }
}
