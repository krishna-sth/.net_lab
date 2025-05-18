

class prime_number
{
    public void prime()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1)
        {

            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} is a Prime number.");
        else
            Console.WriteLine($"{num} is Not a Prime number.");
    }
}
